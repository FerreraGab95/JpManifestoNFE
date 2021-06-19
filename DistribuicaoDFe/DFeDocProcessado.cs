using System;
using System.Collections.Generic;
using System.Text;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public class DFeDocProcessado : DFeDoc
    {
        internal DFeDocProcessado(long nsu, Type schemaType, object docData)
        {
            NSU = nsu;
            SchemaType = schemaType;
            DocData = docData;
        }


        /// <summary>
        /// Tipo do schema do documento;
        /// </summary>
        public Type SchemaType { get; internal set; }


        /// <summary>
        /// Dados do documento;
        /// </summary>
        public object DocData { get; internal set; }
    }
}
