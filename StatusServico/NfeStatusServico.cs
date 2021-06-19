using System.Security.Cryptography.X509Certificates;
using NFeStatusServico;
using System.Threading.Tasks;
using XsdClasses;
using System.ServiceModel;
using System.Net.Http;
using System.Dynamic;

namespace JpManifestoNFE.StatusServico
{
    public class NfeStatusServico : SefazWebService, INfeStatusServico
    {
        /// <summary>
        /// Schemas requeridos para a execução do serviço;
        /// </summary>
        private readonly WebServiceSchemas[] ServiceSchemas = new WebServiceSchemas[]
        {
            WebServiceSchemas.tiposBasico,
            WebServiceSchemas.consStatServ,
            WebServiceSchemas.leiauteConsStatServ,
        };

        private const string VERSAO_SERVICO = "4.00";

        private string webServiceUri;

        private readonly TCodUfIBGE uf;

        /// <summary>
        /// Cria uma nova instância de NFeStatusServico, serviço que informa o status de todos 
        /// os outros WebServices da UF informada;
        /// </summary>
        /// <param name="certificate"></param>
        /// <param name="schemaManager"></param>
        /// <param name="webServiceUrl"></param>
        private NfeStatusServico(X509Certificate2 certificate, SchemaManager schemaManager, TCodUfIBGE uf) :
            base(certificate, schemaManager) 
        {
            this.uf = uf;
            webServiceUri = NfeStatusServicoURIs.ServiceURI(uf);
        }


        /// <summary>
        /// Retorna uma instância de INFeStatusServico, serviço que informa o status de todos 
        /// os outros WebServices da UF informada;
        public static INfeStatusServico GetNfeStatusServico(X509Certificate2 certificate, SchemaManager schemaManager, TCodUfIBGE uf)
        {
            return new NfeStatusServico(certificate, schemaManager, uf);
        }


        /// <summary>
        /// Retorna o status dos WebServices;
        /// </summary>
        /// <returns></returns>
        public async Task<TRetConsStatServ> GetStatusService()
        {
            var client = new NFeStatusServico4SoapClient(webServiceBinding, new EndpointAddress(webServiceUri));

            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;
            
            TConsStatServ consStatServ = new TConsStatServ();
            consStatServ.cUF = uf;
            consStatServ.tpAmb = TAmb.Producao;
            consStatServ.versao = VERSAO_SERVICO;
            consStatServ.xServ = TConsStatServXServ.STATUS;

            var xmlDoc = ParseToXmlDocument(consStatServ, typeof(TConsStatServ));
            ValidateXmlFromSchema(xmlDoc, ServiceSchemas);

            try
            {
                var dadosRequest = await client.nfeStatusServicoNFAsync(xmlDoc);
                return ParseFromXml<TRetConsStatServ>(dadosRequest.nfeResultMsg, typeof(TRetConsStatServ));
            }
            catch(EndpointNotFoundException) 
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
        }
    }
}
