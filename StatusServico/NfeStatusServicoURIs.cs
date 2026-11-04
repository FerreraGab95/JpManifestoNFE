namespace JpManifestoNFE.StatusServico
{
    public static class NfeStatusServicoURIs
    {
        /// <summary>
        /// Retorna a URI do WebService baseada na UF informada;
        /// </summary>
        /// <returns></returns>
        public static string ServiceURI(UfIBGE uf)
            => ServiceURI(uf, TipoAmbiente.Producao);

        /// <summary>Endpoints from the official SVRS NF-e service catalog, checked 2026-11-04.</summary>
        public static string ServiceURI(UfIBGE uf, TipoAmbiente ambiente)
        {
            if (!Enum.IsDefined(uf)) throw new ArgumentOutOfRangeException(nameof(uf));
            if (!Enum.IsDefined(ambiente)) throw new ArgumentOutOfRangeException(nameof(ambiente));
            if (ambiente == TipoAmbiente.Homologacao)
                return uf switch
                {
                    UfIBGE.Amazonas => "https://homnfe.sefaz.am.gov.br/services2/services/NfeStatusServico4",
                    UfIBGE.Bahia => "https://hnfe.sefaz.ba.gov.br/webservices/NFeStatusServico4/NFeStatusServico4.asmx",
                    UfIBGE.Goias => "https://homolog.sefaz.go.gov.br/nfe/services/NFeStatusServico4",
                    UfIBGE.Minas_Gerais => "https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeStatusServico4",
                    UfIBGE.Mato_Grosso_Do_Sul => "https://hom.nfe.sefaz.ms.gov.br/ws/NFeStatusServico4",
                    UfIBGE.Mato_Grosso => "https://homologacao.sefaz.mt.gov.br/nfews/v2/services/NfeStatusServico4",
                    UfIBGE.Maranhao => "https://hom.sefazvirtual.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx",
                    UfIBGE.Pernambuco => "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NFeStatusServico4",
                    UfIBGE.Parana => "https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeStatusServico4",
                    UfIBGE.Rio_Grande_Do_Sul => "https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx",
                    UfIBGE.Sao_Paulo => "https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx",
                    _ => "https://nfe-homologacao.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx"
                };
            switch (uf)
            {
                case UfIBGE.Amazonas:
                    return "https://nfe.sefaz.am.gov.br/services2/services/NfeStatusServico4";
                case UfIBGE.Bahia:
                    return "https://nfe.sefaz.ba.gov.br/webservices/NFeStatusServico4/NFeStatusServico4.asmx";
                case UfIBGE.Ceara:
                    return "https://nfe.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx";
                case UfIBGE.Goias:
                    return "https://nfe.sefaz.go.gov.br/nfe/services/NFeStatusServico4";
                case UfIBGE.Minas_Gerais:
                    return "https://nfe.fazenda.mg.gov.br/nfe2/services/NFeStatusServico4";
                case UfIBGE.Mato_Grosso_Do_Sul:
                    return "https://nfe.sefaz.ms.gov.br/ws/NFeStatusServico4";
                case UfIBGE.Mato_Grosso:
                    return "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeStatusServico4";
                case UfIBGE.Maranhao:
                    return "https://www.sefazvirtual.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx";
                case UfIBGE.Pernambuco:
                    return "https://nfe.sefaz.pe.gov.br/nfe-service/services/NFeStatusServico4";
                case UfIBGE.Parana:
                    return "https://nfe.sefa.pr.gov.br/nfe/NFeStatusServico4";
                case UfIBGE.Rio_Grande_Do_Sul:
                    return "https://nfe.sefazrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx";
                case UfIBGE.Sao_Paulo:
                    return "https://nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx";
                default:
                    return "https://nfe.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx";
            }
        }
    }
}
