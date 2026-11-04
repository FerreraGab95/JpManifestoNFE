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

        public int Sequencia { get; }

        /// <summary>
        /// Tipo de ambiente da manifestação;
        /// </summary>
        internal TAmb TipoAmb { get; set; }

        /// <summary>
        /// Identificação única do evento;
        /// </summary>
        public string IdEvento { get => $"ID{((int)TipoEvento)}{ChaveNFe}{Sequencia:D2}"; }


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
                if (value == null || value.Length is < 15 or > 255)
                    throw new ArgumentException("A justificativa deve conter entre 15 e 255 caracteres.");
                justificativaEvento = value;
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
            : this(tipoEvento, chaveNFe, documentoCliente, 1) { }

        public ManifestoNFe(TpEvento tipoEvento, string chaveNFe, string documentoCliente, int sequencia)
        {
            if (!Enum.IsDefined(tipoEvento)) throw new ArgumentOutOfRangeException(nameof(tipoEvento));
            if (sequencia < 1 || sequencia > (tipoEvento == TpEvento.Op_Ciencia ? 1 : 2))
                throw new ArgumentOutOfRangeException(nameof(sequencia));
            Sequencia = sequencia;
            TipoEvento = tipoEvento;
            ChaveNFe = chaveNFe;
            DocCliente = documentoCliente;
            TipoAmb = EnumsHelper.GetTipoAmbienteAsTAmb(TipoAmbiente.Producao);
        }


        internal TEvento_confRecebto_v1_00 GetEventoManifesto()
        {
            if (!ValidacaoTipos.ValidateChaveNFe(ChaveNFe)) throw new FormatException("Chave da NF-e inválida.");
            if (!ValidacaoTipos.ValidateCnpj(DocCliente) && !ValidacaoTipos.ValidateCpf(DocCliente))
                throw new FormatException("Informe CPF ou CNPJ sem pontuação.");
            if (TipoEvento == TpEvento.Op_Nao_Realizada && string.IsNullOrWhiteSpace(JustificativaEvento))
                throw new ArgumentException("Informe a justificativa da operação não realizada.");
            var evento = new TEvento_confRecebto_v1_00();
            var infoEvento = new TEventoInfEvento_confRecebto_v1_00();

            infoEvento.chNFe = ChaveNFe;
            infoEvento.cOrgao = TCOrgaoIBGE.Item91; //Ambiente Nacional;
            infoEvento.tpAmb = TipoAmb;
            infoEvento.tpEvento = ManifestacaoEnumHelper.GetCodigoEvento(TipoEvento);
            infoEvento.verEvento = VERSAO_EVENTOS;
            infoEvento.nSeqEvento = Sequencia.ToString(System.Globalization.CultureInfo.InvariantCulture);
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
