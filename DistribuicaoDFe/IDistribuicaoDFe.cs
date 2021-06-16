using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public interface IDistribuicaoDFe
    {
        /// <summary>
        /// Retorna o documento que possui o NSU informado;
        /// </summary>
        /// <param name="nsu"></param>
        /// <returns></returns>
        Task<retDistDFeInt> ConsultaNSU(int nsu);


        /// <summary>
        /// Retorna o documento que possui a chave NFe informada;
        /// </summary>
        /// <param name="chaveNfe">Chave da NFe contendo 44 dígitos</param>
        /// <returns></returns>
        Task<retDistDFeInt> ConsultaChaveNFe(string chaveNfe);


        /// <summary>
        /// Retorna todos os documentos à partir do número NSU informado;
        /// </summary>
        /// <param name="ultNSU"></param>
        /// <returns></returns>
        Task<retDistDFeInt> ConsultaUltimoNSU(int ultNSU);
    }
}
