using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeProcEventoNFe : DFeDoc
    {
        public const string SCHEMA_NAME = "procEventoNFe";

        public DFeProcEventoNFe() { }

        public TProcEvento_procEventoNFe_v1_00 procEventoNFe { get; internal set; }

        public static DFeProcEventoNFe GetInstance(retDistDFeIntLoteDistDFeIntDocZip xmlDocZip)
        {
            CompareSchemas(SCHEMA_NAME, xmlDocZip.schema);

            var procEventoNFe = new DFeProcEventoNFe();
            procEventoNFe.NSU = long.Parse(xmlDocZip.NSU);

            using (var docStream = DFeDocStreamHelper.ExtractDocXmlContent(xmlDocZip.Value))
            {
                procEventoNFe.NSU = long.Parse(xmlDocZip.NSU);
                procEventoNFe.procEventoNFe = (TProcEvento_procEventoNFe_v1_00)DFeDocStreamHelper.
                    ParseXmlContentToObject(typeof(TProcEvento_procEventoNFe_v1_00),
                    docStream);
            }

            return procEventoNFe;
        }
    }
}
