using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using XsdClasses;

namespace JpManifestoNFE
{
    public class SchemaManager
    {
        /// <summary>
        /// Nome do schema que contém a declaração dos tipos básicos presentes nos outros arquivos;
        /// </summary>

        private DirectoryInfo schemaDirectory;

        public SchemaManager(string schemaDirectory) 
        {
            this.schemaDirectory = new DirectoryInfo(schemaDirectory);
        }


        /// <summary>
        /// Retorna os XML Schemas de validação com o namespace, informados no parâmetro schema;
        /// </summary>
        /// <param name="defaultNamespace"></param>
        /// <param name="xsdClassType">Tipo do objeto de requisição do serviço, encontrado em XSDClasses</param>
        /// <returns></returns>
        public XmlSchemaSet GetSchemas(string defaultNamespace, params WebServiceSchemas[] schemas)
        {
            var schemaFiles = new List<FileInfo>();

            if (!schemaDirectory.Exists)
                throw new DirectoryNotFoundException(ErrorMsgs.XSD_PATH_NOT_FOUND);

            
            //Utiliza o pattern para que seja retornado apenas os schemas relacionadas ao WebService escolhido;
            foreach(var schema in schemas)
            {
                schemaFiles.AddRange(schemaDirectory.GetFiles($"{schema}*"));
            };

            if (schemaFiles.Count == 0) 
            {
                string missingSchema = String.Empty;

                foreach(var schemaFile in schemas)
                {
                    missingSchema += $"{schemaFile}_vX.XX.xsd\n";
                }

                throw new FileNotFoundException(ErrorMsgs.XSD_FILE_NOT_FOUND + missingSchema);
            }

            var schemaSet = new XmlSchemaSet();

            foreach (var schemaFile in schemaFiles)
            {
                schemaSet.Add(defaultNamespace, schemaFile.FullName);
            }

            return schemaSet;
        }
    }

    public enum WebServiceSchemas
    {
        /// <summary>
        /// Schema contendo os tipos básicos presentes nas operações do WebService.
        /// </summary>
        tiposBasico,
        /// <summary>
        /// Leiaute da NF-e.
        /// </summary>
        leiauteNFe,
        ///Mensagem de envio de lote de NF-e.
        enviNFe,
        /// <summary>
        /// Mensagem de consulta processamento do lote de NF-e
        ///transmitida.
        /// </summary>
        consReciNFe,
        /// <summary>
        /// Leiaute de compartilhamento da NF-e.
        /// </summary>
        procNFe,
        /// <summary>
        /// Mensagem de solicitação de inutilização de numeração de NFe
        /// </summary>
        inutNFe,
        /// <summary>
        /// Mensagem de consulta da situação atual da NF-e.
        /// </summary>
        consSitNFe,
        /// <summary>
        /// Mensagem da consulta do status do serviço de autorização de
        ///NF-e.
        /// </summary>
        consStatServ,
        /// <summary>
        /// Leiaute do serviço de status de consulta,
        /// </summary>
        leiauteConsStatServ,
        /// <summary>
        /// Tipos da Distribuição DFe.
        /// </summary>
        tiposDistDFe,
        /// <summary>
        /// Distribuição DFe: Consulta notas emitidas para o CNPJ informado;
        /// </summary>
        distDFeInt,
    }
}
