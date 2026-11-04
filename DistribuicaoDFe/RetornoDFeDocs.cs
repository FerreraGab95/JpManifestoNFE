using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class RetornoDFeDocs : IRetornoDFeDocs
    {
        /// <summary>
        /// Lista de documentos XML processados;
        /// </summary>
        private List<DFeDoc> dfeDocs;

        private long ultimoNSU;

        private long maxNSU;
        private retDistDFeInt? respostaOriginal;

        private List<retDistDFeIntLoteDistDFeIntDocZip> dfeDocZips;

        private RetornoDFeDocs(List<DFeDoc> dfeDocs, long ultimoNSU, long maxNSU)
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
            ArgumentNullException.ThrowIfNull(retornoDistDFe);
            var docs = GetRetornoDocs(retornoDistDFe);

            var docZips = retornoDistDFe.loteDistDFeInt == null ?
                new List<retDistDFeIntLoteDistDFeIntDocZip>() :
                retornoDistDFe.loteDistDFeInt.docZip?.ToList() ?? new();

            return new RetornoDFeDocs(docs, Nsu.ParseOptional(retornoDistDFe.ultNSU) ?? 0,
                Nsu.ParseOptional(retornoDistDFe.maxNSU) ?? 0)
            { dfeDocZips = docZips, respostaOriginal = retornoDistDFe };
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
                try
                {
                    if (xmlDocZip == null || string.IsNullOrWhiteSpace(xmlDocZip.schema))
                        throw new InvalidDataException("Documento retornado sem schema.");
                    DFeDoc doc = xmlDocZip.schema switch
                    {
                        "resNFe_v1.00.xsd" or "resNFe_v1.01.xsd" => DFeDocResumoNFe.GetInstance(xmlDocZip),
                        "resEvento_v1.00.xsd" or "resEvento_v1.01.xsd" => DFeDocResumoEvento.GetInstance(xmlDocZip),
                        "procNFe_v4.00.xsd" => DFeDocProcNFe.GetInstance(xmlDocZip),
                        "procEventoNFe_v1.00.xsd" => DFeProcEventoNFe.GetInstance(xmlDocZip),
                        _ => DFeDocDesc.GetInstance(xmlDocZip)
                    };
                    doc.DocumentoOriginal = xmlDocZip;
                    docsExtraidos.Add(doc);
                }
                catch (Exception ex) when (ex is InvalidOperationException or IOException or InvalidDataException or FormatException or ArgumentException or System.Xml.XmlException)
                {
                    docsExtraidos.Add(new DFeProcessingFailure
                    {
                        DocumentoOriginal = xmlDocZip, Schema = xmlDocZip?.schema ?? "",
                        Message = ex.GetBaseException().Message
                    });
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
            return checked((int)maxNSU);
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
            return checked((int)ultimoNSU);
        }

        public long GetUltimoNSU64() => ultimoNSU;
        public long GetMaxNSU64() => maxNSU;
        public retDistDFeInt? GetRespostaOriginal() => respostaOriginal;
        public IReadOnlyList<DFeProcessingFailure> GetProcessingFailures() => dfeDocs.OfType<DFeProcessingFailure>().ToArray();
    }
}
