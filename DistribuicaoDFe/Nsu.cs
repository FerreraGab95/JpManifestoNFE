using System.Globalization;

namespace JpManifestoNFE.DistribuicaoDFe;

public static class Nsu
{
    public const long Maximum = 999_999_999_999_999;
    public static long? ParseOptional(string? value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (value.Length > 15 || value.Any(c => c < '0' || c > '9')
            || !long.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out var result))
            throw new FormatException("NSU deve conter de 1 a 15 dígitos.");
        return result;
    }
    public static string Format(long value) => value is >= 0 and <= Maximum
        ? value.ToString("D15", CultureInfo.InvariantCulture)
        : throw new ArgumentOutOfRangeException(nameof(value), "NSU deve conter de 1 a 15 dígitos.");
}
