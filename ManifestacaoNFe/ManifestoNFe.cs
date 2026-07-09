using SefazSchemasClasses;

namespace JpManifestoNFE.ManifestacaoNFe
{
    public class ManifestoNFe
    {
        /// <summary>
        /// Tipo de evento a ser manifestado;
        /// </summary>
        public TpEvento TipoEvento { get; private set; }

        public string ChaveNFe { get; private set; }

        private const string VERSAO_EVENTOS = "1.00";

        private const string SEQ_EVENTO = "1";

        /// <summary>
        /// Tipo de ambiente da manifestação;
        /// </summary>
        internal TAmb TipoAmb { get; set; }

        /// <summary>
        /// Identificação única do evento;
        /// </summary>
        public string IdEvento { get => $"ID{((int)TipoEvento)}{ChaveNFe}0{SEQ_EVENTO}"; }


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
        public ManifestoNFe(TpEvento tipoEvento, string chaveNFe, string documentoCliente)
        {
            TipoEvento = tipoEvento;
            ChaveNFe = chaveNFe;
            DocCliente = documentoCliente;
            TipoAmb = EnumsHelper.GetTipoAmbienteAsTAmb(TipoAmbiente.Producao);
        }


        internal TEvento_confRecebto_v1_00 GetEventoManifesto()
        {
            var evento = new TEvento_confRecebto_v1_00();
            var infoEvento = new TEventoInfEvento_confRecebto_v1_00();

            infoEvento.chNFe = ChaveNFe;
            infoEvento.cOrgao = TCOrgaoIBGE.Item91; //Ambiente Nacional;
            infoEvento.tpAmb = TipoAmb;
            infoEvento.tpEvento = ManifestacaoEnumHelper.GetCodigoEvento(TipoEvento);
            infoEvento.verEvento = VERSAO_EVENTOS;
            infoEvento.nSeqEvento = SEQ_EVENTO;
            infoEvento.dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            infoEvento.Id = IdEvento;
            infoEvento.ItemElementName = ValidacaoTipos.ValidateCnpj(DocCliente) ? TipoDoc.CNPJ : TipoDoc.CPF;
            infoEvento.Item = DocCliente;
            infoEvento.detEvento = new TEventoInfEventoDetEvento_confRecebto_v1_00();
            infoEvento.detEvento.versao = TEventoInfEventoDetEventoVersao.Item100;
            infoEvento.detEvento.descEvento = ManifestacaoEnumHelper.GetDescricaoEvento(TipoEvento);
            infoEvento.detEvento.xJust = JustificativaEvento;

            evento.infEvento = infoEvento;
            evento.versao = VERSAO_EVENTOS;

            return evento;
        }
    }
}
