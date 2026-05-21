using SefazSchemasClasses;
using System.Threading.Tasks;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public interface IDistribuicaoDFe
    {
        /// <summary>
        /// Retorna o documento que possui o NSU informado;
        /// </summary>
        /// <param name="nsu"></param>
        /// <exception cref="SefazReturnException"/>
        /// <returns></returns>
        Task<retDistDFeInt> ConsultaNSU(int nsu);


        /// <summary>
        /// Retorna o documento que possui a chave NFe informada;
        /// </summary>
        /// <param name="chaveNfe">Chave da NFe contendo 44 dígitos</param>
        /// <exception cref="SefazReturnException"/>
        /// <returns></returns>
        Task<retDistDFeInt> ConsultaChaveNFe(string chaveNfe);


        /// <summary>
        /// Retorna todos os documentos à partir do número NSU informado até o último documento emitido,
        /// ou o tamanho máximo de documentos por lote (50 documentos);
        /// </summary>
        /// <param name="ultNSU"></param>
        /// <exception cref="SefazReturnException"/>
        /// <returns></returns>
        Task<retDistDFeInt> ConsultaUltimoNSU(int ultNSU);
    }
}
