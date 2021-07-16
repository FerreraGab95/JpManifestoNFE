using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NFeDistribuicaoDFe;
using System.Linq;
using XsdClasses;
using System.Xml;

namespace JpManifestoNFE.ManifestacaoNFe
{
    public class ManifestacaoNFe : SefazWebService, IManifestacaoNFe
    {
        private TUf uf;

        private const string VERSAO_WEB_SERVICE = "1.00";


        /// <summary>
        /// Código esperado de retorno do lote enviado;
        /// </summary>
        private int expectedReturnCode = 128;


        /// <summary>
        /// Assinador dos XMLs de eventos;
        /// </summary>
        private XmlSign xmlSigner;

        #if TEST
            private TAmb tipoAmbiente = TAmb.Homologacao;
            private const string WEB_SERVICE_URI = "https://hom.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"; //Homologação (Testes)
        #else
            private TAmb tipoAmbiente = TAmb.Producao;
            private const string WEB_SERVICE_URI = "https://www.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"; //Produção
        #endif

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

        private ManifestacaoNFe(X509Certificate2 certificate, SchemaHelper schemaManager, TUf uf)
            : base(certificate, schemaManager)
        {
            this.uf = uf;
            xmlSigner = new XmlSign(certificate);
        }

        
        public static IManifestacaoNFe GetManifestacaoNFe(X509Certificate2 certificate, SchemaHelper schemaManager, TUf uf)
        {
            return new ManifestacaoNFe(certificate, schemaManager, uf);
        }


        public async Task<TRetEnvEvento> ManifestarNFes(params ManifestoNFe[] manifestoNFes)
        {
            if (manifestoNFes.Length > 20)
            {
                throw new ArgumentOutOfRangeException(ErrorMsgs.MANIFEST_LOTE_EXCEDIDO);
            }
            else if (manifestoNFes == null || manifestoNFes.Length == 0)
                throw new ArgumentException(ErrorMsgs.MANIFEST_LOTE_VAZIO);

            var client = new NFeRecepcaoEvento.NFeRecepcaoEvento4SoapClient(webServiceBinding,
            new EndpointAddress(WEB_SERVICE_URI));


            var envEvento = new TEnvEvento();
            envEvento.idLote = DateTime.Now.ToString("yyyyMMddHHmm");
            envEvento.versao = VERSAO_WEB_SERVICE;

            var docXml = SignAndImportEventos(XmlHelper.ParseToXmlDocument(envEvento, 
                typeof(TEnvEvento), DEFAULT_NAMESPACE), manifestoNFes);

            ValidateXmlFromSchemas(docXml, ServiceSchemas);

            try
            {
                client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

                var channel = client.ChannelFactory.CreateChannel(new EndpointAddress(WEB_SERVICE_URI));
                var requestMsg = new NFeRecepcaoEvento.nfeRecepcaoEventoNFRequest(docXml.DocumentElement);

                var requestData = await channel.nfeRecepcaoEventoNFAsync(requestMsg);
                var result = XmlHelper.ParseFromXml<TRetEnvEvento>(requestData.nfeRecepcaoEventoNFResult, typeof(TRetEnvEvento));
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
                eventos[i].TipoAmbiente = tipoAmbiente;

                var xmlEvento = XmlHelper.ParseToXmlDocument(eventos[i].GetEventoManifesto(), typeof(TEvento), DEFAULT_NAMESPACE)
                    .DocumentElement;

                xmlSigner.SignXml(xmlEvento, $"#{eventos[i].IdEvento}");

                var appendNode = xmlDocument.ImportNode(xmlEvento, true);
                xmlDocument.DocumentElement.AppendChild(appendNode);
            }

            return xmlDocument;
        }
    }
}
