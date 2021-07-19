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
        protected readonly SchemaHelper schemaManager;

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
        protected CustomBinding webServiceBinding
        {
            get
            {
                return GetBindingSOAP_1_2();
            }
        }


        /// <summary>
        /// Versão do protocolo SOAP utilizado no WebService;
        /// </summary>
        protected EnvelopeVersion envelopeVersion;

        public SefazWebService(X509Certificate2 clientCertificate, SchemaHelper schemaFactory) 
        {
            this.schemaManager = schemaFactory;
            this.clientCertificate = clientCertificate;
        }


        private CustomBinding GetBindingSOAP_1_2()
        {
            var basicBinding = new BasicHttpBinding();
            basicBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            basicBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            basicBinding.TextEncoding = Encoding.UTF8;
            /*
            O tamanho padrão das mensagens de retorno é de 65536 bytes, que é insuficiente para alguns tipos de serviços
            como o de Distribuição de DFe, que pode conter um grande número de caracteres dependendo do tipo de pesquisa feita,
            por isso, foi atríbuido o dobro do valor padrão. 
            */
            basicBinding.MaxReceivedMessageSize *= 10;


            //webServiceBinding é uma bind customizada para utilizar o Soap 1.2 ao invés do Soap 1.1 que é padrão do HttpBinding
            //permitindo assim uma compatibilidade maior com WebServices de estados diferentes;
            //Solução desenvolvida por (Nicolas Giannone)https://stackoverflow.com/users/10662490/nicolas-giannone
            var webServiceBinding = new CustomBinding(basicBinding);

            var textBindingElement = new TextMessageEncodingBindingElement
            {
                WriteEncoding = Encoding.UTF8,
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
            };

            webServiceBinding.Elements[0] = textBindingElement;

            return webServiceBinding;
        }


        /// <summary>
        /// Verifica se o documento Xml está de acordo com os parâmetros definidos no schema;
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="schemas"></param>
        protected void ValidateXmlFromSchemas(XmlDocument doc, params WebServiceSchemas[] schemas) 
        {
            string exMessage = string.Empty;
           
            doc.Schemas.Add(schemaManager.GetSchemas(schemas));

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
