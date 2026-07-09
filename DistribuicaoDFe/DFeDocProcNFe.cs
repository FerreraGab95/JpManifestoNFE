using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocProcNFe : DFeDoc
    {
        public const string SCHEMA_NAME = "procNFe";

        private DFeDocProcNFe() { }

        public DFeDocProcNFe(TNfeProc nFeProc)
        {
            NFeProc = nFeProc;
        }



        /// <summary>
        /// Leiaute de compartilhamento da NF-e
        /// </summary>
        public TNfeProc NFeProc { get; internal set; }


        public static DFeDocProcNFe GetInstance(retDistDFeIntLoteDistDFeIntDocZip xmlDocZip)
        {
            CompareSchemas(SCHEMA_NAME, xmlDocZip.schema);

            var procNFe = new DFeDocProcNFe();
            procNFe.NSU = long.Parse(xmlDocZip.NSU);

            using (var docStream = DFeDocStreamHelper.ExtractDocXmlContent(xmlDocZip.Value))
            {
                procNFe.NSU = long.Parse(xmlDocZip.NSU);
                procNFe.NFeProc = (TNfeProc)DFeDocStreamHelper.ParseXmlContentToObject(typeof(TNfeProc),
                    docStream);
            }

            return procNFe;
        }
    }
}
