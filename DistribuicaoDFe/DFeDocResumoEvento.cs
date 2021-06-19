using System;
using System.Collections.Generic;
using System.Text;
using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocResumoEvento : DFeDoc
    {
        /// <summary>
        ///Conjunto de informações resumidas de um evento de NF-e
        /// </summary>
        public resEvento ResumoEvento { get; internal set; }
    }
}
