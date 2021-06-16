using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace JpManifestoNFE
{
    public class SefazWebService
    {
        protected readonly SchemaManager schemaManager;

        /// <summary>
        /// Namescpace padrão dos XMls dos WebServices;
        /// </summary>
        protected const string defaultNamespace = "http://www.portalfiscal.inf.br/nfe";


        /// <summary>
        /// Certificado do cliente;
        /// </summary>
        protected X509Certificate2 clientCertificate;


        /// <summary>
        /// Binding com as definições da conexão com o WebService;
        /// </summary>
        protected BasicHttpBinding basicHttpBinding;

        public SefazWebService(X509Certificate2 clientCertificate, SchemaManager schemaFactory) 
        {
            this.schemaManager = schemaFactory;
            this.clientCertificate = clientCertificate;

            basicHttpBinding = new BasicHttpBinding();
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            /*
            O tamanho padrão das mensagens de retorno é de 65536 bytes, que é insuficiente para alguns tipos de serviços
            como o de Distribuição de DFe, que pode conter um grande número de caracteres dependendo do tipo de pesquisa feita,
            por isso, foi atríbuido o dobro do valor padrão. 
            */
            basicHttpBinding.MaxReceivedMessageSize *= 2;
        }


        /// <summary>
        /// Serializa um objeto de tipo presente em XsdClasses para um XmlDocument;
        /// </summary>
        /// <param name="toXmlDoc"></param>
        /// <param name="objType"></param>
        /// <returns></returns>
        protected XmlDocument ParseToXmlDocument(object toXmlDoc, Type objType)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(objType, defaultNamespace);

            Exception exception;

            using (var sWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(sWriter))
                {
                    try
                    {
                        xmlSerializer.Serialize(xmlWriter, toXmlDoc);
                        string xml = sWriter.ToString();
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);
                        return doc;
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                    }
                }
            }

            if (exception != null) throw exception;

            return null;
        }



        /// <summary>
        /// Deserializa um nó Xml para uma instância de um objeto de tipo especificado em XsdClasses;
        /// </summary>
        /// <param name="responseNode"></param>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        protected T ParseFromXml<T>(XmlNode responseNode, Type typeToConvert)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeToConvert);

            XmlDocument doc = new XmlDocument();
            XmlNode toImport = doc.ImportNode(responseNode, true);
            doc.AppendChild(toImport);

            using (var sReader = new StringReader(responseNode.OuterXml))
            {
                var des = xmlSerializer.Deserialize(sReader);
                return (T)des;
            }
        }


        /// <summary>
        /// Verifica se o documento Xml está de acordo com os parâmetros definidos no schema;
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="schemas"></param>
        protected void ValidateXmlFromSchema(XmlDocument doc, params WebServiceSchemas[] schemas) 
        {
            string exMessage = string.Empty;
           
            doc.Schemas.Add(schemaManager.GetSchemas(defaultNamespace, schemas));

            doc.Validate((e, s) =>
            {
                exMessage += "\n" + s.Message;
            });


            if (!string.IsNullOrEmpty(exMessage)) 
            {
                throw new XmlSchemaValidationException($"{ErrorMsgs.XSD_FILE_NOT_FOUND}\n{exMessage}");
            }
        }
    }
}
