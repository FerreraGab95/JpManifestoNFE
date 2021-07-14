using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace JpManifestoNFE
{
    class SefazReturnException : Exception
    {
        public SefazReturnException()
        {
        }

        public SefazReturnException(string message) : base(message)
        {
        }

        public SefazReturnException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SefazReturnException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
