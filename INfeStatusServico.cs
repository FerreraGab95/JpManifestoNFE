using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XsdClasses;

namespace JpManifestoNFE
{
    public interface INfeStatusServico
    {
        Task<TRetConsStatServ> GetStatusService();
    }
}
