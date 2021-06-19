using System;
using System.Collections.Generic;
using System.Text;
using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocResumoNFe : DFeDoc
    {
        /// <summary>
        ///Conjunto de informações resumo da NF-e localizadas
        /// </summary>
        public resNFe ResumoNFe { get; internal set; }
    }
}
