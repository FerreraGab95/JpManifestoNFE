using System.Runtime.Serialization;

namespace JpManifestoNFE
{
    public class SefazReturnException : Exception
    {
        public int ExceptionCode { get; set; }
        public string? MotivoOficial { get; }
        public SefazSchemasClasses.retDistDFeInt? RespostaDistribuicao { get; }

        public SefazReturnException(SefazSchemasClasses.retDistDFeInt resposta)
            : this(int.Parse(resposta.cStat), resposta.xMotivo)
        {
            MotivoOficial = resposta.xMotivo;
            RespostaDistribuicao = resposta;
        }

        public SefazReturnException()
        {
        }

        public SefazReturnException(int exceptionCode, string message) : base($"{message} Cod:{exceptionCode}.")
        {
            this.ExceptionCode = exceptionCode;
        }

        public SefazReturnException(int exceptionCode, string message, Exception innerException) :
            base($"{message} Cod:{exceptionCode}.", innerException)
        {
            this.ExceptionCode = exceptionCode;
        }

        protected SefazReturnException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
