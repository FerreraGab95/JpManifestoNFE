using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using XsdClasses;
using System.Xml.Serialization;

namespace JpManifestoNFE.DistribuicaoDFe
{
    /// <summary>
    /// Processa a mensagem de retorno da distribuição DFe;
    /// </summary>
    internal static class RetornoDFeProcessor
    {

        /// <summary>
        /// Extrai e processa todos os documentos da mensagem de retorno da DistribuicaoDFe;
        /// </summary>
        /// <returns></returns>
        internal static List<DFeDoc> GetRetornoDocs(retDistDFeInt retornoDFe)
        {
            var docsExtraidos = new List<DFeDoc>();

            foreach(var xmlDocZip in retornoDFe.loteDistDFeInt.docZip)
            {
                using (Stream docStream = ExtractDocXmlContent(xmlDocZip.Value))
                {
                    if (xmlDocZip.schema.Contains(nameof(resNFe)))
                    {
                        var docResNfe = new DFeDocResumoNFe();
                        docResNfe.NSU = long.Parse(xmlDocZip.NSU);
                        docResNfe.ResumoNFe = (resNFe)ParseXmlContentToObject(typeof(resNFe), docStream);
                        docsExtraidos.Add(docResNfe);
                    }
                    else if (xmlDocZip.schema.Contains(nameof(resEvento)))
                    {
                        var docResEvento = new DFeDocResumoEvento();
                        docResEvento.NSU = long.Parse(xmlDocZip.NSU);
                        docResEvento.ResumoEvento = (resEvento)ParseXmlContentToObject(typeof(resEvento), docStream);
                        docsExtraidos.Add(docResEvento);
                    }
                    /*O nome procNFe existe apenas no arquivo schema, o tipo da NFe processada é TProtNFe
                     o motivo de tal divergência é desconhecido, talvez seja resolvido em uma futura atualização
                    dos web services.*/
                    else if (xmlDocZip.schema.Contains("procNFe"))
                    {
                        var docProcNFe = new DFeDocProcNFe();
                        docProcNFe.NSU = long.Parse(xmlDocZip.NSU);
                        docProcNFe.NFeProc = (TNfeProc)ParseXmlContentToObject(typeof(TNfeProc), docStream);
                        docsExtraidos.Add(docProcNFe);
                    }
                    else
                    {
                        var docDesc = new DFeDocDesc();
                        docDesc.NSU = long.Parse(xmlDocZip.NSU);
                        docDesc.ConteudoDoc = (string)ParseXmlContentToObject(typeof(object), docStream);
                        docsExtraidos.Add(docDesc);
                    }
                }
            }

            return docsExtraidos;
        }

        

        /// <summary>
        /// Retorna um stream com o conteúdo do documento XMl descompactado;
        /// </summary>
        /// <param name="docBuffer"></param>
        /// <returns></returns>
        private static Stream ExtractDocXmlContent(byte[] docBuffer)
        {
            var resultMemoryStream = new MemoryStream();

            using(Stream readMemoryStream = new MemoryStream(docBuffer))
            using(GZipStream zipStream = new GZipStream(readMemoryStream, CompressionMode.Decompress, false))
            {
                //Grava o conteúdo descompactado no stream de resultado;
                zipStream.CopyTo(resultMemoryStream);

                //Reinicia o stream de resultado para a posição inicial;
                resultMemoryStream.Seek(0, SeekOrigin.Begin);
            }

            return resultMemoryStream;
        }


        /// <summary>
        /// Converte o Stream do arquivo XMl para a intância do documento;
        /// </summary>
        /// <param name="schemaType"></param>
        /// <param name="docStream"></param>
        /// <returns></returns>
        private static object ParseXmlContentToObject(Type schemaType, Stream docStream)
        {
            if (schemaType != typeof(object))
            {
                var xmlSerializer = new XmlSerializer(schemaType, SefazWebService.DEFAULT_NAMESPACE);
                return xmlSerializer.Deserialize(docStream);
            }
            else
            {   //Caso o XML seja de um schema desconhecido, o seu conteúdo será lido como uma string;
                using (StreamReader reader = new StreamReader(docStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
