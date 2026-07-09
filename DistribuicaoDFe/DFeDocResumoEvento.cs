using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocResumoEvento : DFeDoc
    {
        public const string SCHEMA_NAME = "resEvento";
        /// <summary>
        ///Conjunto de informações resumidas de um evento de NF-e
        /// </summary>
        public resEvento ResumoEvento { get; internal set; }

        public DFeDocResumoEvento() { }


        public static DFeDocResumoEvento GetInstance(retDistDFeIntLoteDistDFeIntDocZip xmlDocZip)
        {
            CompareSchemas(SCHEMA_NAME, xmlDocZip.schema);

            var docResEvento = new DFeDocResumoEvento();
            docResEvento.NSU = long.Parse(xmlDocZip.NSU);

            using (var docStream = DFeDocStreamHelper.ExtractDocXmlContent(xmlDocZip.Value))
            {
                docResEvento.NSU = long.Parse(xmlDocZip.NSU);
                docResEvento.ResumoEvento = (resEvento)DFeDocStreamHelper.
                    ParseXmlContentToObject(typeof(resEvento), docStream);
            }

            return docResEvento;
        }
    }
}
