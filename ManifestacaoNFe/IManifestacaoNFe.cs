using SefazSchemasClasses;
using System.Threading.Tasks;

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
        Task<TRetEnvEvento_confRecebto_v1_00> ManifestarNFes(params ManifestoNFe[] manifestoNFes);
    }
}
