using SefazSchemasClasses;
using System.Threading.Tasks;

namespace JpManifestoNFE.StatusServico
{
    /// <summary>
    /// Retorna o status de serviço da Sefaz;
    /// </summary>
    public interface INfeStatusServico
    {

        /// <summary>
        /// Retorna o status dos WebServices da Sefaz;
        /// </summary>
        /// <exception cref="SefazReturnException"/>
        /// <returns></returns>
        Task<TRetConsStatServ> GetStatusService();
    }
}
