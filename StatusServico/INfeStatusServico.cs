using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XsdClasses;

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
        /// <returns></returns>
        Task<TRetConsStatServ> GetStatusService();
    }
}
