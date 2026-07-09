using System.IO.Compression;
using System.Xml.Serialization;

namespace JpManifestoNFE.DistribuicaoDFe
{
    internal class DFeDocStreamHelper
    {
        /// <summary>
        /// Retorna um stream com o conteúdo do documento XMl descompactado;
        /// </summary>
        /// <param name="docBuffer"></param>
        /// <returns></returns>
        internal static Stream ExtractDocXmlContent(byte[] docBuffer)
        {
            var resultMemoryStream = new MemoryStream();

            using (Stream readMemoryStream = new MemoryStream(docBuffer))
            using (GZipStream zipStream = new GZipStream(readMemoryStream, CompressionMode.Decompress, false))
            {
                //Grava o conteúdo descompactado no stream de resultado;
                zipStream.CopyTo(resultMemoryStream);

                //Reinicia o stream de resultado para a posição inicial;
                resultMemoryStream.Seek(0, SeekOrigin.Begin);
            }

            return resultMemoryStream;
        }


        /// <summary>
        /// Converte o Stream do arquivo XML para a instância do documento;
        /// </summary>
        /// <param name="schemaType"></param>
        /// <param name="docStream"></param>
        /// <returns></returns>
        internal static object ParseXmlContentToObject(Type schemaType, Stream docStream, int nsu = 0)
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
