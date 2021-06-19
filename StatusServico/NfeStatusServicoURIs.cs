using System;
using System.Collections.Generic;
using System.Text;
using JpManifestoNFE;
using XsdClasses;

namespace JpManifestoNFE.StatusServico
{
    public static class NfeStatusServicoURIs
    {
        /// <summary>
        /// Retorna a URI do WebService baseada na UF informada;
        /// </summary>
        /// <returns></returns>
        public static string ServiceURI(TCodUfIBGE uf)
        {
            switch (uf)
            {
                case TCodUfIBGE.Amazonas:
                    return "https://nfe.sefaz.am.gov.br/services2/services/NfeStatusServico4";
                case TCodUfIBGE.Bahia:
                    return "https://nfe.sefaz.ba.gov.br/webservices/NFeStatusServico4/NFeStatusServico4.asmx";
                case TCodUfIBGE.Ceará:
                    return "https://nfe.sefaz.ce.gov.br/nfe4/services/NFeStatusServico4?wsdl";
                case TCodUfIBGE.Goiás:
                    return "https://nfe.sefaz.go.gov.br/nfe/services/NFeStatusServico4?wsdl";
                case TCodUfIBGE.Minas_Gerais:
                    return "https://nfe.fazenda.mg.gov.br/nfe2/services/NFeStatusServico4";
                case TCodUfIBGE.Mato_Grosso_do_Sul:
                    return "https://nfe.sefaz.ms.gov.br/ws/NFeStatusServico4";
                case TCodUfIBGE.Mato_Grosso:
                    return "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeStatusServico4?wsdl";
                case TCodUfIBGE.Maranhão:
                    return "https://www.sefazvirtual.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx";
                case TCodUfIBGE.Pernambuco:
                    return "https://nfe.sefaz.pe.gov.br/nfe-service/services/NFeStatusServico4";
                case TCodUfIBGE.Paraná:
                    return "https://nfe.sefa.pr.gov.br/nfe/NFeStatusServico4?wsdl";
                case TCodUfIBGE.Rio_Grande_do_Sul:
                    return "https://nfe.sefazrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx";
                case TCodUfIBGE.São_Paulo:
                    return "https://nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx";
                default:
                    return "https://nfe.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx";
            }
        }
    }
}
