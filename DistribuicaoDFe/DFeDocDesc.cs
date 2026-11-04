using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    /// <summary>
    /// Tipo de documento desconhecido, ou ainda não suportado;
    /// </summary>
    public class DFeDocDesc : DFeDoc
    {
        private DFeDocDesc() { }

        public DFeDocDesc(string nomeSchema, string conteudoDoc)
        {
            NomeSchema = nomeSchema;
            ConteudoDoc = conteudoDoc;
        }

        /// <summary>
        /// Nome do tipo de schema do documento;
        /// </summary>
        public string NomeSchema { get; internal set; }


        /// <summary>
        /// Conteúdo do documento;
        /// </summary>
        public string ConteudoDoc { get; internal set; }


        public static DFeDocDesc GetInstance(retDistDFeIntLoteDistDFeIntDocZip xmlDocZip)
        {
            var docDesc = new DFeDocDesc();
            docDesc.NumeroNSU = Nsu.ParseOptional(xmlDocZip.NSU);

            using (var docStream = DFeDocStreamHelper.ExtractDocXmlContent(xmlDocZip.Value))
            {
                docDesc.NomeSchema = xmlDocZip.schema;
                docDesc.ConteudoDoc = (string)DFeDocStreamHelper.
                    ParseXmlContentToObject(typeof(object), docStream);
            }

            return docDesc;
        }
    }
}
