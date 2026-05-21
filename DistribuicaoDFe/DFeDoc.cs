using System;

namespace JpManifestoNFE.DistribuicaoDFe
{
    public abstract class DFeDoc
    {
        /// <summary>
        /// Número sequencial único;
        /// </summary>
        public long NSU { get; internal set; }


        /// <summary>
        /// Verifica se o schema do objeto e o schema do documento a ser extraído são compatíveis.
        /// </summary>
        /// <param name="schemaName"></param>
        /// <param name="docZipSchema"></param>
        /// <exception cref="ArgumentException"></exception>
        protected static void CompareSchemas(string schemaName, string docZipSchema)
        {
            if (!docZipSchema.Contains(schemaName))
                throw new ArgumentException("O schema do documento não é compatível com o schema do " +
                    "objeto a ser instanciado.");
        }
    }
}
