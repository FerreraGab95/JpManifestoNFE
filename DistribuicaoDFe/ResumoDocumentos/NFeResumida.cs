using System;
using System.Collections.Generic;
using System.Text;
using XsdClasses;

namespace JpManifestoNFE.DistribuicaoDFe.ResumoDocumentos
{
    class NFeResumida
    {
        public NFeResumida()
        {

        }

        public TUf EstadoEmissao { get; set; }

        public int NumeroNFe { get; set; }

        public string NaturezaOp { get; set; }

        public DateTime DataHoraEmissao { get; set; }

        public DateTime DatHoraSaidaOuEntrada { get; set; }

        public TipoNFe TipoOp { get; set; }

        public Entidade Emitente { get; set; }

        public Entidade Destinatario { get; set; }

        public Transporte Transporte { get; set; }

        public Cobranca Cobranca { get; set; }

        public decimal ValorNota { get; set; }

        public decimal ValorICMS { get; set; }

        public decimal ValorFCP { get; set; }

        public decimal ValorST { get; set; }

        public decimal ValorFCPST { get; set; }

        public decimal ValorIPI { get; set; }

        public decimal ValorPIS { get; set; }

        public decimal ValorCOFINS { get; set; }
    }


    public enum TipoNFe
    {
        Entrada,
        Saida
    }
}
