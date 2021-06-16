using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace JpManifestoNFE
{
    class SefazCodeErrorException : Exception
    {
        public SefazCodeErrorException()
        {
        }

        public SefazCodeErrorException(string message) : base(message)
        {
        }

        public SefazCodeErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SefazCodeErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
