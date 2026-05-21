using SefazSchemasClasses;
using System;
using System.Linq;

namespace JpManifestoNFE
{
    public static class EnumsHelper
    {
        public static TAmb GetTipoAmbienteAsTAmb(TipoAmbiente tpAmb)
        {
            if (tpAmb == TipoAmbiente.Producao)
                return TAmb.Item1;
            else
                return TAmb.Item2;
        }


        public static TCodUfIBGE GetTCodUfIBGEFromUF(UfIBGE uf)
        {
            string ufValue = ((int)uf).ToString();
            string[] tCodNames = Enum.GetNames(typeof(TCodUfIBGE));

            foreach (string name in tCodNames)
            {
                if (tCodNames.Contains(ufValue))
                {
                    return (TCodUfIBGE)Enum.Parse(typeof(TCodUfIBGE), name);
                }
            }

            return TCodUfIBGE.Item33;
        }

        public static UfIBGE GetUfIBGEFromTCodUF(TCodUfIBGE uf)
        {
            int codUF = int.Parse(uf.ToString().Replace("Item", ""));

            return (UfIBGE)codUF;
        }
    }


    /// <summary>
    /// Tipo de Ambiente do Web Service;
    /// </summary>
    public enum TipoAmbiente
    {
        Producao = 1,
        Homologacao
    }

    public enum UfIBGE
    {
        Rondonia = 11,
        Acre = 12,
        Amazonas = 13,
        Roraima = 14,
        Para = 15,
        Amapa = 16,
        Tocantins = 17,
        Maranhao = 21,
        Piaui = 22,
        Ceara = 23,
        Rio_Grande_do_Norte = 24,
        Paraiba = 25,
        Pernambuco = 26,
        Alagoas = 27,
        Sergipe = 28,
        Bahia = 29,
        Minas_Gerais = 31,
        Espirito_Santo = 32,
        Rio_De_Janeiro = 33,
        Sao_Paulo = 35,
        Parana = 41,
        Santa_Catarina = 42,
        Rio_Grande_Do_Sul = 43,
        Mato_Grosso_Do_Sul = 50,
        Mato_Grosso = 51,
        Goias = 52,
        Distrito_Federal = 53
    }
}
