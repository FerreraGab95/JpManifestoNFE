using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XsdClasses;

namespace JpManifestoNFE.ManifestacaoNFe
{
    public interface IManifestacaoNFe
    {
        /// <summary>
        /// Manifesta as NFes informadas, o limite máximo de NFes a serem manifestadas em um lote é de 20,
        /// caso seja passada uma quantidade superior, será lançada um ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="manifestoNFes"></param>
        /// <exception cref="SefazReturnException"/>
        /// <returns></returns>
        Task<TRetEnvEvento> ManifestarNFes(params ManifestoNFe[] manifestoNFes);
    }
}
