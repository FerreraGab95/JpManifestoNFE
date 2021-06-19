using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
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
        public const string DEFAULT_NAMESPACE = "http://www.portalfiscal.inf.br/nfe";


        /// <summary>
        /// Certificado do cliente;
        /// </summary>
        protected X509Certificate2 clientCertificate;


        /// <summary>
        /// Binding com as definições da conexão com o WebService;
        /// </summary>
        protected CustomBinding webServiceBinding;

        public SefazWebService(X509Certificate2 clientCertificate, SchemaManager schemaFactory) 
        {
            this.schemaManager = schemaFactory;
            this.clientCertificate = clientCertificate;

            var basicBinding = new BasicHttpBinding();
            basicBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            basicBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            basicBinding.TextEncoding = Encoding.Default;
            /*
            O tamanho padrão das mensagens de retorno é de 65536 bytes, que é insuficiente para alguns tipos de serviços
            como o de Distribuição de DFe, que pode conter um grande número de caracteres dependendo do tipo de pesquisa feita,
            por isso, foi atríbuido o dobro do valor padrão. 
            */
            basicBinding.MaxReceivedMessageSize *= 10;


            //webServiceBinding é uma bind customizada para utilizar o Soap 1.2 ao invés do Soap 1.1 que é padrão do HttpBinding
            //permitindo assim uma compatibilidade maior com WebServices de estados diferentes;
            //Solução desenvolvida por (Nicolas Giannone)https://stackoverflow.com/users/10662490/nicolas-giannone
            webServiceBinding = new CustomBinding(basicBinding);

            var textBindingElement = new TextMessageEncodingBindingElement
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
            };

            webServiceBinding.Elements[0] = textBindingElement;
        }


        /// <summary>
        /// Serializa um objeto de tipo presente em XsdClasses para um XmlDocument;
        /// </summary>
        /// <param name="toXmlDoc"></param>
        /// <param name="objType"></param>
        /// <returns></returns>
        protected XmlDocument ParseToXmlDocument(object toXmlDoc, Type objType)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(objType, DEFAULT_NAMESPACE);

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
           
            doc.Schemas.Add(schemaManager.GetSchemas(DEFAULT_NAMESPACE, schemas));

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
