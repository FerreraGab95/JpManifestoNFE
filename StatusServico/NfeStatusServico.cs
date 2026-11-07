using NFeStatusServico;
using SefazSchemasClasses;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;

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

        private readonly UfIBGE uf;
        private readonly TipoAmbiente tipoAmbiente;
        public TipoAmbiente Ambiente => tipoAmbiente;
        public string Endereco => webServiceUri;


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
        private NfeStatusServico(X509Certificate2 certificate, SchemaHelper schemaManager, UfIBGE uf, TipoAmbiente ambiente = TipoAmbiente.Producao) :
            base(certificate, schemaManager)
        {
            this.uf = uf;
            tipoAmbiente = ambiente;
            webServiceUri = NfeStatusServicoURIs.ServiceURI(uf, ambiente);
        }


        /// <summary>
        /// Retorna uma instância de INFeStatusServico, serviço que informa o status de todos 
        /// os outros WebServices da UF informada;
        public static INfeStatusServico GetNfeStatusServico(X509Certificate2 certificate, SchemaHelper schemaManager, UfIBGE uf)
        {
            return new NfeStatusServico(certificate, schemaManager, uf);
        }

        public static INfeStatusServico GetNfeStatusServico(X509Certificate2 certificate, SchemaHelper schemaManager, UfIBGE uf, TipoAmbiente ambiente)
            => new NfeStatusServico(certificate, schemaManager, uf, ambiente);


        /// <summary>
        /// Retorna o status dos WebServices;
        /// </summary>
        /// <returns></returns>
        public async Task<TRetConsStatServ> GetStatusService()
        {
            TConsStatServ consStatServ = new TConsStatServ();
            consStatServ.cUF = EnumsHelper.GetTCodUfIBGEFromUF(uf);
            consStatServ.tpAmb = EnumsHelper.GetTipoAmbienteAsTAmb(tipoAmbiente);
            consStatServ.versao = VERSAO_SERVICO;
            consStatServ.xServ = TConsStatServXServ.STATUS;

            var xmlDoc = XmlHelper.ParseToXmlDocument(consStatServ, typeof(TConsStatServ), DEFAULT_NAMESPACE);
            ValidateXmlFromSchemas(xmlDoc, ServiceSchemas);

            var binding = webServiceBinding;
            binding.OpenTimeout = TimeSpan.FromSeconds(10);
            binding.SendTimeout = TimeSpan.FromSeconds(15);
            binding.CloseTimeout = TimeSpan.FromSeconds(5);
            var client = new NFeStatusServico4SoapClient(binding, new EndpointAddress(webServiceUri));
            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

            try
            {
                var requestData = await client.nfeStatusServicoNFAsync(xmlDoc);
                var result = XmlHelper.ParseFromXml<TRetConsStatServ>(requestData.nfeResultMsg, typeof(TRetConsStatServ));
                if (int.Parse(result.cStat) != expectedReturnCode)
                    throw new SefazReturnException(int.Parse(result.cStat), result.xMotivo);
                return result;
            }
            catch (TimeoutException)
            {
                client.Abort();
                throw;
            }
            catch (EndpointNotFoundException)
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
            finally { CloseClient(client); }
        }
    }
}
