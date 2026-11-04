using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocResumoNFe : DFeDoc
    {
        public const string SCHEMA_NAME = "resNFe";

        public DFeDocResumoNFe() { }

        /// <summary>
        ///Conjunto de informações resumo da NF-e localizadas
        /// </summary>
        public resNFe ResumoNFe { get; internal set; }

        public static DFeDocResumoNFe GetInstance(retDistDFeIntLoteDistDFeIntDocZip xmlDocZip)
        {
            CompareSchemas(SCHEMA_NAME, xmlDocZip.schema);

            var docResNfe = new DFeDocResumoNFe();
            docResNfe.NumeroNSU = Nsu.ParseOptional(xmlDocZip.NSU);

            using (var docStream = DFeDocStreamHelper.ExtractDocXmlContent(xmlDocZip.Value))
            {
                docResNfe.NumeroNSU = Nsu.ParseOptional(xmlDocZip.NSU);
                docResNfe.ResumoNFe = (resNFe)DFeDocStreamHelper.
                    ParseXmlContentToObject(typeof(resNFe), docStream);
            }

            return docResNfe;
        }
    }
}
