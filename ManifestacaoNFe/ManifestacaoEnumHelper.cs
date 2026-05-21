
using SefazSchemasClasses;
using System;
using System.Linq;

namespace JpManifestoNFE.ManifestacaoNFe
{
    public static class ManifestacaoEnumHelper
    {
        /// <summary>
        /// Retorna o código do evento como string. Ex: Confirmação Operação = "210200".
        /// </summary>
        /// <param name="tipoEvento"></param>
        /// <returns></returns>
        public static TEventoInfEventoTpEvento GetCodigoEvento(TpEvento tipoEvento)
        {
            string[] names = Enum.GetNames(typeof(TEventoInfEventoTpEvento));
            string tpEventoName = names.FirstOrDefault(x => x.Contains(((int)tipoEvento).ToString()));

            return (TEventoInfEventoTpEvento)Enum.Parse(typeof(TEventoInfEventoTpEvento), tpEventoName);
        }



        /// <summary>
        /// Converter um valor detEventoDescEvento em TipoEvento.
        /// </summary>
        /// <param name="descEvento"></param>
        /// <returns></returns>
        public static TpEvento GetTipoEventoFromDescEvento(detEventoDescEvento descEvento)
        {
            switch (descEvento)
            {
                case detEventoDescEvento.CienciadaOperacao:
                    return TpEvento.Op_Ciencia;
                case detEventoDescEvento.OperacaonaoRealizada:
                    return TpEvento.Op_Nao_Realizada;
                case detEventoDescEvento.ConfirmacaodaOperacao:
                    return TpEvento.Op_Confirmacao;
                case detEventoDescEvento.DesconhecimentodaOperacao:
                    return TpEvento.Op_Desconhecimento;
                default:
                    return TpEvento.Op_Ciencia;
            }
        }


        /// <summary>
        /// Retorna a descrição do evento baseado no TipoEvento informado.
        /// </summary>
        /// <param name="tipoEvento"></param>
        /// <returns></returns>
        public static TEventoInfEventoDetEventoDescEvento GetDescricaoEvento(TpEvento tipoEvento)
        {
            switch (tipoEvento)
            {
                case TpEvento.Op_Confirmacao:
                    return TEventoInfEventoDetEventoDescEvento.ConfirmacaodaOperacao;
                case TpEvento.Op_Ciencia:
                    return TEventoInfEventoDetEventoDescEvento.CienciadaOperacao;
                case TpEvento.Op_Desconhecimento:
                    return TEventoInfEventoDetEventoDescEvento.DesconhecimentodaOperacao;
                case TpEvento.Op_Nao_Realizada:
                    return TEventoInfEventoDetEventoDescEvento.OperacaonaoRealizada;
                default: return TEventoInfEventoDetEventoDescEvento.CienciadaOperacao;
            }
        }
    }

    public enum TpEvento
    {
        Op_Confirmacao = 210200,
        Op_Ciencia = 210210,
        Op_Desconhecimento = 210220,
        Op_Nao_Realizada = 210240
    }
}
