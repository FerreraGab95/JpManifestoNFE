using SefazSchemasClasses;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Xml;

namespace JpManifestoNFE.ManifestacaoNFe
{
    public class ManifestacaoNFe : SefazWebService, IManifestacaoNFe
    {
        private UfIBGE uf;

        private const string VERSAO_WEB_SERVICE = "1.00";


        /// <summary>
        /// Código esperado de retorno do lote enviado;
        /// </summary>
        private int expectedReturnCode = 128;


        /// <summary>
        /// Assinador dos XMLs de eventos;
        /// </summary>
        private XmlSign xmlSigner;

        private TipoAmbiente tipoAmbiente = TipoAmbiente.Producao;
        private const string WEB_SERVICE_HOM_URI = "https://hom1.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"; //Homologação (Testes)
        private const string WEB_SERVICE_PROD_URI = "https://www.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"; //Produção

        /// <summary>
        /// Número máximo de NFes por lote;
        /// </summary>
        public const int MAX_NFE_LOTE = 20;

        private string WebServiceUri
        {
            get
            {
                return tipoAmbiente == TipoAmbiente.Producao ?
                WEB_SERVICE_PROD_URI : WEB_SERVICE_HOM_URI;
            }
        }




        /// <summary>
        /// Schemas requeridos para a execução do serviço;
        /// </summary>
        private readonly WebServiceSchemas[] ServiceSchemas = new WebServiceSchemas[]
        {
            //WebServiceSchemas.tiposBasico_v1,
            WebServiceSchemas.leiauteConfRecebto,
            WebServiceSchemas.envConfRecebto,
            //WebServiceSchemas.xmldsig
        };

        private ManifestacaoNFe(X509Certificate2 certificate, SchemaHelper schemaManager, UfIBGE uf,
            TipoAmbiente tipoAmbiente = TipoAmbiente.Producao) : base(certificate, schemaManager)
        {
            this.tipoAmbiente = tipoAmbiente;
            this.uf = uf;
            xmlSigner = new XmlSign(certificate);
        }


        public static IManifestacaoNFe GetManifestacaoNFe(X509Certificate2 certificate,
            SchemaHelper schemaManager, UfIBGE uf, TipoAmbiente tipoAmbiente = TipoAmbiente.Producao)
        {
            return new ManifestacaoNFe(certificate, schemaManager, uf, tipoAmbiente);
        }

        public async Task<TRetEnvEvento_confRecebto_v1_00> ManifestarNFes(params ManifestoNFe[] manifestoNFes)
        {
            if (manifestoNFes.Length > MAX_NFE_LOTE)
            {
                throw new ArgumentOutOfRangeException(ErrorMsgs.MANIFEST_LOTE_EXCEDIDO);
            }
            else if (manifestoNFes == null || manifestoNFes.Length == 0)
                throw new ArgumentException(ErrorMsgs.MANIFEST_LOTE_VAZIO);

            var client = new NFeRecepcaoEvento.NFeRecepcaoEvento4SoapClient(webServiceBinding,
            new EndpointAddress(WebServiceUri));


            var envEvento = new TEnvEvento_confRecebto_v1_00();
            envEvento.idLote = DateTime.Now.ToString("yyyyMMddHHmm");
            envEvento.versao = VERSAO_WEB_SERVICE;

            var docXml = SignAndImportEventos(XmlHelper.ParseToXmlDocument(envEvento,
                typeof(TEnvEvento_confRecebto_v1_00), DEFAULT_NAMESPACE), manifestoNFes);

            ValidateXmlFromSchemas(docXml, ServiceSchemas);

            try
            {
                client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

                var channel = client.ChannelFactory.CreateChannel(new EndpointAddress(WebServiceUri));
                var requestMsg = new NFeRecepcaoEvento.nfeRecepcaoEventoNFRequest(docXml.DocumentElement);

                var requestData = await channel.nfeRecepcaoEventoNFAsync(requestMsg);
                var result = XmlHelper.ParseFromXml<TRetEnvEvento_confRecebto_v1_00>(requestData.nfeRecepcaoEventoNFResult, typeof(TRetEnvEvento_confRecebto_v1_00));
                SefazReturnCodeHelper.ThrowIfCodeIsError(int.Parse(result.cStat), expectedReturnCode);

                return result;
            }
            catch (EndpointNotFoundException)
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
        }


        /// <summary>
        /// Assina digitalmente os eventos e os importam para o documento xml;
        /// </summary>
        /// <returns></returns>
        private XmlDocument SignAndImportEventos(XmlDocument xmlDocument, ManifestoNFe[] eventos)
        {
            for (int i = 0; i < eventos.Length; i++)
            {
                eventos[i].TipoAmb = EnumsHelper.GetTipoAmbienteAsTAmb(tipoAmbiente);

                var xmlEvento = XmlHelper.ParseToXmlDocument(eventos[i].GetEventoManifesto(), typeof(TEvento_confRecebto_v1_00), DEFAULT_NAMESPACE)
                    .DocumentElement;

                xmlSigner.SignXml(xmlEvento, $"#{eventos[i].IdEvento}");

                var appendNode = xmlDocument.ImportNode(xmlEvento, true);
                xmlDocument.DocumentElement.AppendChild(appendNode);
            }

            return xmlDocument;
        }
    }
}
