using System;
using System.Collections.Generic;
using System.Text;
using XsdClasses;
using System.Linq;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class RetornoDFeDocs : IRetornoDFeDocs
    {
        /// <summary>
        /// Lista de documentos XML processados;
        /// </summary>
        List<DFeDoc> dfeDocs;


        private RetornoDFeDocs(List<DFeDoc> dfeDocs)
        {
            this.dfeDocs = dfeDocs;
        }


        /// <summary>
        /// Retorna uma instância de IRetornoDFeDocsProcessor;
        /// </summary>
        /// <param name="retornoDistDFe">Retorno de uma consulta do WebService DistribuiçãoDFe</param>
        /// <returns></returns>
        public static IRetornoDFeDocs ProcessRetornoDFeDocs(retDistDFeInt retornoDistDFe)
        {
            var docs = RetornoDFeProcessor.GetRetornoDocs(retornoDistDFe);
            return new RetornoDFeDocs(docs);
        }

        public List<DFeDoc> GetAll()
        {
            return dfeDocs;
        }

        public List<DFeDocDesc> GetDocumentosDesconhecidos()
        {
            var dfeDescDocs = new List<DFeDocDesc>();

            foreach(var doc in dfeDocs)
            {
                if (doc is DFeDocDesc)
                    dfeDescDocs.Add(doc as DFeDocDesc);
            }

            return dfeDescDocs;
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
    }
}
