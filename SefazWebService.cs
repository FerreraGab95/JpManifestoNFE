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
        protected readonly ISchemaFactory schemaFactory;

        protected const string defaultNamespace = "http://www.portalfiscal.inf.br/nfe";

        protected X509Certificate2 clientCertificate;

        protected BasicHttpBinding basicHttpBinding;

        public SefazWebService(X509Certificate2 clientCertificate, ISchemaFactory schemaFactory) 
        {
            this.schemaFactory = schemaFactory;
            this.clientCertificate = clientCertificate;

            basicHttpBinding = new BasicHttpBinding();
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
        }


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


        protected object ParseFromXml(XmlNode responseNode, Type typeToConvert)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeToConvert);

            XmlDocument doc = new XmlDocument();
            XmlNode toImport = doc.ImportNode(responseNode, true);
            doc.AppendChild(toImport);

            using (var sReader = new StringReader(responseNode.OuterXml))
            {
                var des = xmlSerializer.Deserialize(sReader);
                return des;
            }
        }


        protected void ValidateXmlFromSchema(XmlDocument doc, SchemasNFe nfeSchema) 
        {
            string exMessage = string.Empty;
           
            doc.Schemas.Add(schemaFactory.GetSchemas(defaultNamespace, nfeSchema));

            doc.Validate((e, s) =>
            {
                exMessage += "\n" + s.Message;
            });


            if (!string.IsNullOrEmpty(exMessage)) 
            {
                throw new XmlSchemaValidationException($"{Resource.xsdSchemaValidationError}\n{exMessage}");
            }
        }
    }
}
