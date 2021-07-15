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
            //WebServiceSchemas.tiposBasico_v4,
            WebServiceSchemas.consStatServ,
            //WebServiceSchemas.leiauteConsStatServ,
        };

        private const string VERSAO_SERVICO = "4.00";

        private string webServiceUri;

        private readonly TCodUfIBGE uf;


        /// <summary>
        /// Código de retorno esperado;
        /// </summary>
        private readonly int expectedReturnCode = 107;

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

            var xmlDoc = XmlHelper.ParseToXmlDocument(consStatServ, typeof(TConsStatServ), DEFAULT_NAMESPACE);
            ValidateXmlFromSchemas(xmlDoc, ServiceSchemas);

            try
            {
                var requestData = await client.nfeStatusServicoNFAsync(xmlDoc);
                var result = XmlHelper.ParseFromXml<TRetConsStatServ>(requestData.nfeResultMsg, typeof(TRetConsStatServ));
                SefazReturnCodeHelper.ThrowIfCodeIsError(int.Parse(result.cStat), expectedReturnCode);
                return result;
            }
            catch(EndpointNotFoundException) 
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
        }
    }
}
