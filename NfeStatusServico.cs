using System.Security.Cryptography.X509Certificates;
using NFeStatusServico;
using System.Threading.Tasks;
using XsdClasses;
using System.ServiceModel;
using System.Net.Http;
using System.Dynamic;

namespace JpManifestoNFE
{
    public class NfeStatusServico : SefazWebService, INfeStatusServico
    {
        private const string VERSAO_SERVICO = "4.00";

        private const string WEB_SERVICE_URL = "https://nfe.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx";


        public NfeStatusServico(X509Certificate2 certificate, ISchemaFactory schemaFactory) :
            base(certificate, schemaFactory) 
        {
        }


        public async Task<TRetConsStatServ> GetStatusService()
        {
            var client = new NFeStatusServico4SoapClient(basicHttpBinding, new EndpointAddress(WEB_SERVICE_URL));

            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;
            
            TConsStatServ consStatServ = new TConsStatServ();
            consStatServ.cUF = TCodUfIBGE.Rio_de_Janeiro;
            consStatServ.tpAmb = TAmb.Producao;
            consStatServ.versao = VERSAO_SERVICO;
            consStatServ.xServ = TConsStatServXServ.STATUS;

            var xmlDoc = ParseToXmlDocument(consStatServ, typeof(TConsStatServ));
            ValidateXmlFromSchema(xmlDoc, SchemasNFe.consStatServ);

            try
            {
                var dadosRequest = await client.nfeStatusServicoNFAsync(xmlDoc);
                return (TRetConsStatServ)ParseFromXml(dadosRequest.nfeResultMsg, typeof(TRetConsStatServ));
            }
            catch(EndpointNotFoundException) 
            {
                throw new HttpRequestException(Resource.sefazConnectionError);
            }
        }
    }
}
