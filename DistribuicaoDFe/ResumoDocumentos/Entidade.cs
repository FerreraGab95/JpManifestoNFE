namespace JpManifestoNFE.DistribuicaoDFe.ResumoDocumentos
{
    public class Entidade
    {
        /// <summary>
        /// CPF ou CNPJ
        /// </summary>
        public string Documento { get; set; }

        public string Nome { get; set; }

        public string NomeFantasia { get; set; }

        public string InscricaoEstadual { get; set; }

        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }

        public string Email { get; set; }
    }
}