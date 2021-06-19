using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NFeDistribuicaoDFe;
using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DistribuicaoDFe : SefazWebService, IDistribuicaoDFe
    {
        //private const string VERSAO = "1.01";
        private string WebServiceUri = "https://www1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx";

        /// <summary>
        /// Schemas requeridos para a execução do serviço;
        /// </summary>
        private readonly WebServiceSchemas[] ServiceSchemas = new WebServiceSchemas[]
        {
            WebServiceSchemas.tiposDistDFe,
            //WebServiceSchemas.tiposBasico,
            WebServiceSchemas.distDFeInt
        };

        private TCodUfIBGE uf;
        private string clienteDoc;


        /// <summary>
        /// Cria uma instância de DistribuicaoDFe que possui métodos de pesquisa de notas fiscais emitidas para o CNPJ do cliente;
        /// </summary>
        /// <param name="certificate">Certificado do cliente</param>
        /// <param name="schemaManager"></param>
        /// <param name="clienteDoc">Número do documento do cliente (Igual ao do certificado)</param>
        /// <param name="uf">UF do Cliente</param>
        private DistribuicaoDFe(X509Certificate2 certificate, SchemaManager schemaManager, 
            string clienteDoc, TCodUfIBGE uf) : base(certificate, schemaManager)
        {
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
        public static IDistribuicaoDFe GetDistribuicaoDFe(X509Certificate2 certificate, SchemaManager schemaManager,
            string clienteDoc, TCodUfIBGE uf)
        {
            return new DistribuicaoDFe(certificate, schemaManager, clienteDoc, uf);
        }


        public async Task<retDistDFeInt> ConsultaChaveNFe(string chaveNfe)
        {
            if (!ValidacaoTipos.ValidateChaveNFe(chaveNfe))
                throw new FormatException(ErrorMsgs.INVALID_CHAVE_NFE);

            var client = new NFeDistribuicaoDFeSoapClient(webServiceBinding, new EndpointAddress(WebServiceUri));
            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

            var consulta = new distDFeIntConsChNFe();

            ///Formata o NSU para o padrão definido no schema.
            consulta.chNFe = chaveNfe;

            var doc = GetElementoRaiz();
            doc.Item1 = consulta;

            var xmlDoc = ParseToXmlDocument(doc, typeof(distDFeInt));
            ValidateXmlFromSchema(xmlDoc, ServiceSchemas);

            try
            {
                var result = await client.nfeDistDFeInteresseAsync(xmlDoc.DocumentElement);
                return ParseFromXml<retDistDFeInt>(result.Body.nfeDistDFeInteresseResult, typeof(retDistDFeInt));
            }
            catch (EndpointNotFoundException)
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
        }


        public async Task<retDistDFeInt> ConsultaUltimoNSU(int ultNSU)
        {
            var client = new NFeDistribuicaoDFeSoapClient(webServiceBinding, new EndpointAddress(WebServiceUri));
            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

            var consulta = new distDFeIntDistNSU();

            ///Formata o NSU para o padrão definido no schema.
            consulta.ultNSU = String.Format("{0:000000000000000}", ultNSU);

            var doc = GetElementoRaiz();
            doc.Item1 = consulta;

            var xmlDoc = ParseToXmlDocument(doc, typeof(distDFeInt));
            ValidateXmlFromSchema(xmlDoc, ServiceSchemas);

            try
            {
                var result = await client.nfeDistDFeInteresseAsync(xmlDoc.DocumentElement);
                return ParseFromXml<retDistDFeInt>(result.Body.nfeDistDFeInteresseResult, typeof(retDistDFeInt));
            }
            catch (EndpointNotFoundException)
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
        }


        public async Task<retDistDFeInt> ConsultaNSU(int nsu)
        {
            var client = new NFeDistribuicaoDFeSoapClient(webServiceBinding, new EndpointAddress(WebServiceUri));
            client.ClientCredentials.ClientCertificate.Certificate = clientCertificate;

            var consulta = new distDFeIntConsNSU();

            ///Formata o NSU para o padrão definido no schema.
            consulta.NSU = String.Format("{0:000000000000000}", nsu);

            var doc = GetElementoRaiz();
            doc.Item1 = consulta;

            var xmlDoc = ParseToXmlDocument(doc, typeof(distDFeInt));
            ValidateXmlFromSchema(xmlDoc, ServiceSchemas);

            try
            {
                var result = await client.nfeDistDFeInteresseAsync(xmlDoc.DocumentElement);
                return ParseFromXml<retDistDFeInt>(result.Body.nfeDistDFeInteresseResult, typeof(retDistDFeInt));
            }
            catch (EndpointNotFoundException)
            {
                throw new HttpRequestException(ErrorMsgs.SEFAZ_CONN_ERROR);
            }
        }


        /// <summary>
        /// Retorna o elemento pai, onde os tipos de consulta se situam;
        /// </summary>
        /// <returns></returns>
        public distDFeInt GetElementoRaiz()
        {
            var distDfe = new distDFeInt();
            distDfe.cUFAutor = uf;
            distDfe.tpAmb = TAmb.Producao;

            //Devido a erros na serialização dos XSDs, alguns campos estão com nomes genéricos, que ao serem alterados,
            //podem causar erros na validação com o schema;
            distDfe.versao = TVerDistDFe.Item101;
            distDfe.ItemElementName = ValidacaoTipos.ValidateCnpj(clienteDoc) ? ItemChoiceType1.CNPJ : ItemChoiceType1.CPF;
            distDfe.Item = clienteDoc;
            distDfe.ItemElementName = ItemChoiceType1.CNPJ;

            return distDfe;
        }
    }
}
