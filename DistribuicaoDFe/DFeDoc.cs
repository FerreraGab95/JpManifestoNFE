namespace JpManifestoNFE.DistribuicaoDFe
{
    public abstract class DFeDoc
    {
        /// <summary>
        /// Número sequencial único;
        /// </summary>
        public long NSU { get => NumeroNSU ?? 0; internal set => NumeroNSU = value; }

        /// <summary>NSU ausente continua ausente; NSU é mantido para consumidores antigos.</summary>
        public long? NumeroNSU { get; internal set; }
        public SefazSchemasClasses.retDistDFeIntLoteDistDFeIntDocZip? DocumentoOriginal { get; internal set; }


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
