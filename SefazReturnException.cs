using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace JpManifestoNFE
{
    public class SefazReturnException : Exception
    {
        public int ExceptionCode { get; set; }

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
