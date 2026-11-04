namespace JpManifestoNFE.DistribuicaoDFe;

/// <summary>Documento preservado que não pôde ser interpretado. Não deve ser descartado.</summary>
public sealed class DFeProcessingFailure : DFeDoc
{
    public string Schema { get; init; } = "";
    public string Message { get; init; } = "";
}
