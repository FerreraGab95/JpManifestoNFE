using System;
using System.Collections.Generic;
using System.Text;

namespace JpManifestoNFE
{
    internal static class ErrorMsgs
    {
        /// <summary>
        /// Mensagem de erro, para quando não é possível se conectar a SEFAZ
        /// </summary>
        public static string SEFAZ_CONN_ERROR = "Não é possível conectar aos serviços da SEFAZ, verifique a conexão, e tente novamente.";

        /// <summary>
        /// Mensagem de erro lançada, quando o arquivo XSD com os tipos básicos não se encontra no diretório de schemas;
        /// </summary>
        public static string XSD_BASIC_TYPES_NOT_FOUND = "O arquivo schema de tipos básicos não se encontra no diretório selecionado.";


        /// <summary>
        /// Mensagem de erro lançada quando um arquivo XSD requisitado para a operação, não se encontra no diretório selecionado;
        /// </summary>
        public static string XSD_FILE_NOT_FOUND = "O arquivo schema não existe no diretório selecionado.";

        /// <summary>
        /// Mensagem de erro lançada quando o diretório dos arquivos Schema não existe ou não se encontram no local específicado;
        /// </summary>
        public static string XSD_PATH_NOT_FOUND = "O diretório dos arquivos schema, não existe, ou não se encontra no local específicado";

        /// <summary>
        /// 
        /// </summary>
        public static string INVALID_CHAVE_NFE = "A chave da NFe informada não é valida.";
    }
}
