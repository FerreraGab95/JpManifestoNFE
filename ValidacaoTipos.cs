using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JpManifestoNFE
{
    internal static class ValidacaoTipos
    {
        private const int CNPJ_DIGITOS = 14;
        private const int CPF_DIGITOS = 11;
        private const int NFE_DIGITOS = 44;

        private static string NFE_PATTERN = $"^\\d{{{NFE_DIGITOS}}}$";
        private static string CPF_PATTERN = $"^\\d{{{CPF_DIGITOS}}}$";
        private static string CNPJ_PATTERN = $"^\\d{{{CNPJ_DIGITOS}}}$";

        public static bool ValidateChaveNFe(string chaveNFe)
        {
            Regex reg = new Regex(NFE_PATTERN);
            return reg.IsMatch(chaveNFe);
        }

        public static bool ValidateCnpj(string cnpj)
        {
            Regex reg = new Regex(CNPJ_PATTERN);
            return reg.IsMatch(cnpj);
        }

        public static bool ValidateCpf(string cpf)
        {
            Regex reg = new Regex(CPF_PATTERN);
            return reg.IsMatch(cpf);
        }
    }
}
