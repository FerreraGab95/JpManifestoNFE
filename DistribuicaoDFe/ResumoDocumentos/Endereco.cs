using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe.ResumoDocumentos
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string CodMunicipio { get; set; }

        public string NomeMunicipio { get; set; }

        public TUf UF { get; set; }

        public string CEP { get; set; }

        public int CodigoPais { get; set; }
    }
}