using System;
using System.Collections.Generic;
using System.Text;

namespace JpManifestoNFE.DistribuicaoDFe
{
    /// <summary>
    /// Tipo de documento desconhecido, ou ainda não suportado;
    /// </summary>
    public class DFeDocDesc : DFeDoc
    {
        /// <summary>
        /// Nome do tipo de schema do documento;
        /// </summary>
        public string NomeSchema { get; internal set; }


        /// <summary>
        /// Conteúdo do documento;
        /// </summary>
        public string ConteudoDoc { get; internal set; }
    }
}
