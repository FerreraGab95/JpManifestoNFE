using SefazSchemasClasses;
using System.Collections.Generic;
using System.Linq;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class RetornoDFeDocs : IRetornoDFeDocs
    {
        /// <summary>
        /// Lista de documentos XML processados;
        /// </summary>
        private List<DFeDoc> dfeDocs;

        private int ultimoNSU;

        private int maxNSU;

        private List<retDistDFeIntLoteDistDFeIntDocZip> dfeDocZips;

        private RetornoDFeDocs(List<DFeDoc> dfeDocs, int ultimoNSU, int maxNSU)
        {
            this.dfeDocs = dfeDocs;
            this.ultimoNSU = ultimoNSU;
            this.maxNSU = maxNSU;
        }


        /// <summary>
        /// Retorna uma instância de IRetornoDFeDocsProcessor;
        /// </summary>
        /// <param name="retornoDistDFe">Retorno de uma consulta do WebService DistribuiçãoDFe</param>
        /// <returns></returns>
        public static IRetornoDFeDocs ProcessRetornoDFeDocs(retDistDFeInt retornoDistDFe)
        {
            var docs = GetRetornoDocs(retornoDistDFe);

            if (retornoDistDFe.maxNSU == null)
                retornoDistDFe.maxNSU = "0";
            if (retornoDistDFe.ultNSU == null)
                retornoDistDFe.ultNSU = "0";

            var docZips = retornoDistDFe.loteDistDFeInt == null ?
                new List<retDistDFeIntLoteDistDFeIntDocZip>() :
                retornoDistDFe.loteDistDFeInt.docZip.ToList();

            return new RetornoDFeDocs(docs, int.Parse(retornoDistDFe.ultNSU),
                int.Parse(retornoDistDFe.maxNSU))
            { dfeDocZips = docZips };
        }


        /// <summary>
        /// Extrai e processa todos os documentos da mensagem de retorno da DistribuicaoDFe;
        /// </summary>
        /// <returns></returns>
        internal static List<DFeDoc> GetRetornoDocs(retDistDFeInt retornoDFe)
        {
            var docsExtraidos = new List<DFeDoc>();

            if (retornoDFe == null || retornoDFe.loteDistDFeInt == null ||
                retornoDFe.loteDistDFeInt.docZip == null)
                return docsExtraidos;

            foreach (var xmlDocZip in retornoDFe.loteDistDFeInt.docZip)
            {
                if (xmlDocZip.schema.Contains(DFeDocResumoNFe.SCHEMA_NAME))
                {
                    docsExtraidos.Add(DFeDocResumoNFe.GetInstance(xmlDocZip));
                }
                else if (xmlDocZip.schema.Contains(DFeDocResumoEvento.SCHEMA_NAME))
                {
                    docsExtraidos.Add(DFeDocResumoEvento.GetInstance(xmlDocZip));
                }
                /*O nome procNFe existe apenas no arquivo schema, o tipo da NFe processada é TProtNFe
                 o motivo de tal divergência é desconhecido, talvez seja resolvido em uma futura atualização
                dos web services.*/
                else if (xmlDocZip.schema.Contains(DFeDocProcNFe.SCHEMA_NAME))
                {
                    docsExtraidos.Add(DFeDocProcNFe.GetInstance(xmlDocZip));
                }
                else if (xmlDocZip.schema.Contains(DFeProcEventoNFe.SCHEMA_NAME))
                {
                    docsExtraidos.Add(DFeProcEventoNFe.GetInstance(xmlDocZip));
                }
                else
                {
                    docsExtraidos.Add(DFeDocDesc.GetInstance(xmlDocZip));
                }
            }

            return docsExtraidos;
        }

        public List<DFeDoc> GetAll()
        {
            return dfeDocs;
        }

        public List<DFeDocDesc> GetDocumentosDesconhecidos()
        {
            var dfeDescDocs = new List<DFeDocDesc>();

            foreach (var doc in dfeDocs)
            {
                if (doc is DFeDocDesc)
                    dfeDescDocs.Add(doc as DFeDocDesc);
            }

            return dfeDescDocs;
        }

        public List<retDistDFeIntLoteDistDFeIntDocZip> GetDocZips()
        {
            return this.dfeDocZips;
        }

        public int GetMaxNSU()
        {
            return maxNSU;
        }

        public List<DFeDocProcNFe> GetNFesProcessadas()
        {
            var procNFes = new List<DFeDocProcNFe>();

            foreach (var doc in dfeDocs)
            {
                if (doc is DFeDocProcNFe)
                    procNFes.Add(doc as DFeDocProcNFe);
            }

            return procNFes;
        }

        public List<DFeProcEventoNFe> GetProcessamentoEventosNFe()
        {
            var procEventosNFe = new List<DFeProcEventoNFe>();

            foreach (var doc in dfeDocs)
            {
                if (doc is DFeProcEventoNFe)
                    procEventosNFe.Add(doc as DFeProcEventoNFe);
            }

            return procEventosNFe;
        }

        public List<DFeDocResumoEvento> GetResumosEventoNFe()
        {
            var resumoEventos = new List<DFeDocResumoEvento>();

            foreach (var doc in dfeDocs)
            {
                if (doc is DFeDocResumoEvento)
                    resumoEventos.Add(doc as DFeDocResumoEvento);
            }

            return resumoEventos;
        }


        public List<DFeDocResumoNFe> GetResumosNFe()
        {
            var resumoNFes = new List<DFeDocResumoNFe>();

            foreach (var doc in dfeDocs)
            {
                if (doc is DFeDocResumoNFe)
                    resumoNFes.Add(doc as DFeDocResumoNFe);
            }

            return resumoNFes;
        }

        public int GetUltimoNSU()
        {
            return ultimoNSU;
        }
    }
}
