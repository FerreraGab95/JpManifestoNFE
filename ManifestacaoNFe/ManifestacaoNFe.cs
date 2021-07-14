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

        //private const string WEB_SERVICE_URI = "https://www.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"; //Produção
        private const string WEB_SERVICE_URI = "https://hom.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"; //Homologação (Testes)
        //private const string WEB_SERVICE_URI = "https://nfe-homologacao.svrs.rs.gov.br/ws/recepcaoevento/recepcaoevento4.asmx";
        //private const string WEB_SERVICE_URI = "https://nfe-homologacao.sefazrs.rs.gov.br/ws/recepcaoevento/recepcaoevento4.asmx";
        //private const string WEB_SERVICE_URI = "https://homnfe.sefaz.am.gov.br/services2/services/RecepcaoEvento4";

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

        private ManifestacaoNFe(X509Certificate2 certificate, SchemaManager schemaManager, TUf uf, EnvelopeVersion envelopeVersion)
            : base(certificate, schemaManager, envelopeVersion)
        {
            this.uf = uf;
            xmlSigner = new XmlSign(certificate);
        }

        
        public static IManifestacaoNFe GetManifestacaoNFe(X509Certificate2 certificate, SchemaManager schemaManager, TUf uf)
        {
            return new ManifestacaoNFe(certificate, schemaManager, uf, EnvelopeVersion.Soap12);
        }


        public async Task<TRetEnvEvento> ManifestarNFes(params ManifestoNFe[] manifestoNFes)
        {
            if (manifestoNFes.Length > 20)
            {
                throw new ArgumentOutOfRangeException(ErrorMsgs.MANIFEST_LOTE_EXCEDIDO);
            }

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
            foreach (var evento in eventos)
            {
                var xmlEvento = XmlHelper.ParseToXmlDocument(evento.GetEventoManifesto(uf), typeof(TEvento), DEFAULT_NAMESPACE)
                    .DocumentElement;

                xmlSigner.SignXml(xmlEvento, $"#{evento.IdEvento}");

                var appendNode = xmlDocument.ImportNode(xmlEvento, true);
                xmlDocument.DocumentElement.AppendChild(appendNode);
            }

            return xmlDocument;
        }
    }
}
