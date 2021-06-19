using System;
using System.Collections.Generic;
using System.Text;
using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocProcNFe : DFeDoc
    {
        /// <summary>
        /// Leiaute de compartilhamento da NF-e
        /// </summary>
        public TNfeProc NFeProc { get; internal set; }
    }
}
