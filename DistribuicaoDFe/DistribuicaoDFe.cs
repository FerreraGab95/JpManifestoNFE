using NFeDistribuicaoDFe;
using SefazSchemasClasses;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Xml;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DistribuicaoDFe : SefazWebService, IDistribuicaoDFe
    {
        private static string WEB_SERVICE_PROD_URI = "https://www1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx";
        private static string WEB_SERVICE_HOM_URI = "https://hom1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx";

        private string WebServiceUri
        {
            get
            {
                if (tipoAmbiente == TipoAmbiente.Producao)
                    return WEB_SERVICE_PROD_URI;
                else
                    return WEB_SERVICE_HOM_URI;
            }
        }

        /// <summary>
        /// Códigos de retorno esperados;
        /// </summary>
        private int[] expectedReturnCodes = { 137, 138 };

        /// <summary>
        /// Tipo de ambiente do serviço;
        /// </summary>
        private TipoAmbiente tipoAmbiente;


        /// <summary>
        /// Schemas requeridos para a execução do serviço;
        /// </summary>
        private readonly WebServiceSchemas[] ServiceSchemas = new WebServiceSchemas[]
        {
            //WebServiceSchemas.tiposDistDFe,
            //WebServiceSchemas.tiposBasico,
            WebServiceSchemas.distDFeInt
        };

        private UfIBGE uf;
        private string clienteDoc;


        /// <summary>
        /// Cria uma instância de DistribuicaoDFe que possui métodos de pesquisa de notas fiscais emitidas para o CNPJ do cliente;
        /// </summary>
        /// <param name="certificate">Certificado do cliente</param>
        /// <param name="schemaManager"></param>
        /// <param name="clienteDoc">Número do documento do cliente (Igual ao do certificado)</param>
        /// <param name="uf">UF do Cliente</param>
        private DistribuicaoDFe(X509Certificate2 certificate, SchemaHelper schemaManager, string clienteDoc,
            UfIBGE uf, TipoAmbiente tipoAmbiente = TipoAmbiente.Producao) : base(certificate, schemaManager)
        {
            this.tipoAmbiente = tipoAmbiente;
            this.clienteDoc = clienteDoc;
            this.uf = uf;
        }


        /// <summary>
        /// Retorna uma instância de IDistribuicaoDFe que possui métodos de pesquisa de notas fiscais emitidas para o CNPJ do cliente;
        /// </summary>
        /// <param name="certificate">Certificado do cliente</param>
        /// <param name="schemaManager"></param>
        /// <param name="clienteDoc">Número do documento do cliente (Igual ao do certificado)</param>
        /// <param name="uf">UF do Cliente</param>
        public static IDistribuicaoDFe GetDistribuicaoDFe(X509Certificate2 certificate, SchemaHelper schemaManager,
            string clienteDoc, UfIBGE uf, TipoAmbiente tipoAmbiente = TipoAmbiente.Producao)
        {
            return new DistribuicaoDFe(certificate, schemaManager, clienteDoc, uf, tipoAmbiente);
        }


        public async Task<retDistDFeInt> ConsultaChaveNFe(string chaveNfe)
        {
            if (!ValidacaoTipos.ValidateChaveNFe(chaveNfe))
                throw new FormatException(ErrorMsgs.INVALID_CHAVE_NFE);

            var consulta = new distDFeIntConsChNFe();

            ///Formata o NSU para o padrão definido no schema.
            consulta.chNFe = chaveNfe;

            var doc = GetElementoRaiz();
            doc.Item1 = consulta;

            var xmlDoc = XmlHelper.ParseToXmlDocument(doc, typeof(distDFeInt), DEFAULT_NAMESPACE);
            ValidateXmlFromSchemas(xmlDoc, ServiceSchemas);

            return await RunClient(xmlDoc);
        }


        public Task<retDistDFeInt> ConsultaUltimoNSU(int ultNSU) => ConsultaUltimoNSU((long)ultNSU);

        public async Task<retDistDFeInt> ConsultaUltimoNSU(long ultNSU)
        {
            var consulta = new distDFeIntDistNSU();

            ///Formata o NSU para o padrão definido no schema.
            consulta.ultNSU = Nsu.Format(ultNSU);

            var doc = GetElementoRaiz();
            doc.Item1 = consulta;

            var xmlDoc = XmlHelper.ParseToXmlDocument(doc, typeof(distDFeInt), DEFAULT_NAMESPACE);
            ValidateXmlFromSchemas(xmlDoc, ServiceSchemas);

            return await RunClient(xmlDoc);
        }


        public Task<retDistDFeInt> ConsultaNSU(int nsu) => ConsultaNSU((long)nsu);

        public async Task<retDistDFeInt> ConsultaNSU(long nsu)
        {
            var consulta = new distDFeIntConsNSU();

            ///Formata o NSU para o padrão definido no schema.
            consulta.NSU = Nsu.Format(nsu);

            var doc = GetElementoRaiz();
            doc.Item1 = consulta;

            var xmlDoc = XmlHelper.ParseToXmlDocument(doc, typeof(distDFeInt), DEFAULT_NAMESPACE);
            ValidateXmlFromSchemas(xmlDoc, ServiceSchemas);

            return await RunClient(xmlDoc);
        }

        private async Task<retDistDFeInt> RunClient(XmlDocument distDoc)
        {
            var client = new NFeDistribuicaoDFeSoapClient(webServiceBinding, new EndpointAddress(WebServiceUri));
            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

            try
            {
                var requestData = await client.nfeDistDFeInteresseAsync(distDoc.DocumentElement);
                var result = XmlHelper.ParseFromXml<retDistDFeInt>(requestData.Body.nfeDistDFeInteresseResult,
                    typeof(retDistDFeInt));
                if (!expectedReturnCodes.Contains(int.Parse(result.cStat)))
                    throw new SefazReturnException(result);

                return result;
            }
            catch (EndpointNotFoundException)
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
            finally { CloseClient(client); }
        }


        /// <summary>
        /// Retorna o elemento pai, onde os tipos de consulta se situam;
        /// </summary>
        /// <returns></returns>
        private distDFeInt GetElementoRaiz()
        {
            var distDfe = new distDFeInt();
            distDfe.cUFAutor = EnumsHelper.GetTCodUfIBGEFromUF(uf);
            distDfe.tpAmb = EnumsHelper.GetTipoAmbienteAsTAmb(tipoAmbiente);

            //Devido a erros na serialização dos XSDs, alguns campos estão com nomes genéricos, que ao serem alterados,
            //podem causar erros na validação com o schema;
            distDfe.versao = TVerDistDFe.Item101;
            distDfe.ItemElementName = ValidacaoTipos.ValidateCnpj(clienteDoc) ?
                TipoDoc.CNPJ : TipoDoc.CPF;
            distDfe.Item = clienteDoc;

            if (!ValidacaoTipos.ValidateCnpj(clienteDoc) && !ValidacaoTipos.ValidateCpf(clienteDoc))
                throw new FormatException("Informe CPF ou CNPJ sem pontuação.");

            return distDfe;
        }
    }
}
