using SefazSchemasClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public interface IRetornoDFeDocs
    {

        /// <summary>
        /// Retorna todos os documentos processados, obtidos da pesquisa;
        /// </summary>
        /// <returns></returns>
        List<DFeDoc> GetAll();

        /// <summary>
        /// Retorna uma lista com o resumo de todas as NFes emitidas para o documento do cliente.
        /// </summary>
        /// <returns></returns>
        List<DFeDocResumoNFe> GetResumosNFe();


        /// <summary>
        /// Retorna uma lista com os eventos relacionados às NFes emitidas para o destinátário
        /// </summary>
        /// <returns></returns>
        List<DFeDocResumoEvento> GetResumosEventoNFe();


        /// <summary>
        /// Retorna uma lista com as NFes processadas que já receberam o evento de ciência da emissão pelo destinatário,
        /// o tipo TnfeProc permite visualizar todos os dados da NFe como produtos, impostos, códigos e etc.
        /// </summary>
        /// <returns></returns>
        List<DFeDocProcNFe> GetNFesProcessadas();


        /// <summary>
        /// Retorna uma lista com os eventos manifestados pelos destinatarios das NFes emitidas pelo usuário.
        /// </summary>
        /// <returns></returns>
        List<DFeProcEventoNFe> GetProcessamentoEventosNFe();


        /// <summary>
        /// Retorna uma lista com documentos de tipos não identificados;
        /// </summary>
        /// <returns></returns>
        List<DFeDocDesc> GetDocumentosDesconhecidos();


        /// <summary>
        /// Retorna todos os documentos no formato original bruto, compactados no formato gzip.
        /// </summary>
        /// <returns></returns>
        List<retDistDFeIntLoteDistDFeIntDocZip> GetDocZips();


        /// <summary>
        /// Retorna o último NSU do último documento da pesquisa.
        /// </summary>
        /// <returns></returns>
        int GetUltimoNSU();


        /// <summary>
        /// Retorna o último NSU do último documento emitido para o usuário.
        /// </summary>
        /// <returns></returns>
        int GetMaxNSU();
    }
}
