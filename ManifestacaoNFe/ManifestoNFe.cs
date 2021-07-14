using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using XsdClasses;

namespace JpManifestoNFE.ManifestacaoNFe
{
    public class ManifestoNFe
    {
        /// <summary>
        /// Tipo de evento a ser manifestado;
        /// </summary>
        public TEventoInfEventoTpEvento TipoEvento { get; private set; }

        public string ChaveNFe { get; private set; }

        private const string VERSAO_EVENTOS = "1.00";

        private const string SEQ_EVENTO = "1";

        /// <summary>
        /// Identificação única do evento;
        /// </summary>
        public string IdEvento { get => $"ID{GetCodigoEvento()}{ChaveNFe}0{SEQ_EVENTO}"; }


        /// <summary>
        /// Justificativa do evento, apenas para evento do tipo "Operação não realizada" (Mínimo 15 caracteres, máximo 255).
        /// </summary>
        public string JustificativaEvento
        {
            get
            {
                return justificativaEvento;
            }
            set
            {
                justificativaEvento = value.Length >= 255 ? value.Substring(0, 255) : value;
            }
        }
        private string justificativaEvento;

        /// <summary>
        /// Documento do cliente (CPF/CNPJ), é necessário ser idêntico ao do certificado digital;
        /// </summary>
        public string DocCliente { get; set; }


        /// <summary>
        /// Cria uma nova instância de ManifestoNFe, que é responsavel por formatar e retornar um documento
        /// de manifestação da NFe de chave informada;
        /// </summary>
        /// <param name="tipoEvento"></param>
        /// <param name="chaveNFe"></param>
        /// <param name="documentoCliente">Documento do cliente (CPF/CNPJ), é necessário ser idêntico ao do certificado digital;</param>
        public ManifestoNFe(TEventoInfEventoTpEvento tipoEvento, string chaveNFe, string documentoCliente)
        {
            TipoEvento = tipoEvento;
            ChaveNFe = chaveNFe;
            DocCliente = documentoCliente;
        }

        private string GetCodigoEvento()
        {
            switch (TipoEvento)
            {
                case TEventoInfEventoTpEvento.ConfirmacaoOperacao:
                    return "210200";
                case TEventoInfEventoTpEvento.CienciaOperacao:
                    return "210210";
                case TEventoInfEventoTpEvento.DesconhecimentoOperacao:
                    return "210220";
                case TEventoInfEventoTpEvento.OperacaoNaoRealizada:
                    return "210240";
                default: return "210210";
            }
        }


        private TEventoInfEventoDetEventoDescEvento GetDescricaoEvento()
        {
            switch (TipoEvento)
            {
                case TEventoInfEventoTpEvento.ConfirmacaoOperacao:
                    return TEventoInfEventoDetEventoDescEvento.ConfirmacaodaOperacao;
                case TEventoInfEventoTpEvento.CienciaOperacao:
                    return TEventoInfEventoDetEventoDescEvento.CienciadaOperacao;
                case TEventoInfEventoTpEvento.DesconhecimentoOperacao:
                    return TEventoInfEventoDetEventoDescEvento.DesconhecimentodaOperacao;
                case TEventoInfEventoTpEvento.OperacaoNaoRealizada:
                    return TEventoInfEventoDetEventoDescEvento.OperacaonaoRealizada;
                default: return TEventoInfEventoDetEventoDescEvento.CienciadaOperacao;
            }
        }


        internal TEvento GetEventoManifesto(TUf ufEvento)
        {
            var evento = new TEvento();
            var infoEvento = new TEventoInfEvento();

            infoEvento.chNFe = ChaveNFe;
            infoEvento.cOrgao = TCOrgaoIBGE.Item91; //Ambiente Nacional;
            infoEvento.tpAmb = TAmb.Homologacao;
            infoEvento.tpEvento = TipoEvento;
            infoEvento.verEvento = VERSAO_EVENTOS;
            infoEvento.nSeqEvento = SEQ_EVENTO;
            infoEvento.dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            infoEvento.Id = IdEvento;
            infoEvento.ItemElementName = ValidacaoTipos.ValidateCnpj(DocCliente) ? ItemChoiceType.CNPJ : ItemChoiceType.CPF;
            infoEvento.Item = DocCliente;
            infoEvento.detEvento = new TEventoInfEventoDetEvento();
            infoEvento.detEvento.versao = TEventoInfEventoDetEventoVersao.Item100;
            infoEvento.detEvento.descEvento = GetDescricaoEvento();
            infoEvento.detEvento.xJust = JustificativaEvento;

            evento.infEvento = infoEvento;
            evento.versao = VERSAO_EVENTOS;

            return evento;
        }
    }
}
