using System.Collections.Concurrent;
using System.IO.Compression;
using System.Xml;
using System.Xml.Serialization;
namespace JpManifestoNFE.DistribuicaoDFe;
internal class DFeDocStreamHelper
{
    private static readonly ConcurrentDictionary<Type, XmlSerializer> Serializers = new();
    internal static Stream ExtractDocXmlContent(byte[] docBuffer)
        => new LimitedReadStream(new GZipStream(new MemoryStream(docBuffer, false), CompressionMode.Decompress));
    internal static object ParseXmlContentToObject(Type schemaType, Stream docStream, int nsu = 0)
    {
        if (schemaType == typeof(object))
        {
            using var text = new StreamReader(docStream);
            return text.ReadToEnd();
        }
        using var reader = XmlReader.Create(docStream, new XmlReaderSettings
        { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null, MaxCharactersInDocument = 32L * 1024 * 1024 });
        return Serializers.GetOrAdd(schemaType, t => new XmlSerializer(t, SefazWebService.DEFAULT_NAMESPACE)).Deserialize(reader)
            ?? throw new InvalidDataException("Documento XML vazio.");
    }
    private sealed class LimitedReadStream(Stream input) : Stream
    {
        private long consumed;
        public override int Read(byte[] buffer, int offset, int count)
        {
            var read = input.Read(buffer, offset, count);
            consumed += read;
            if (consumed > 32L * 1024 * 1024) throw new InvalidDataException("Documento descompactado excede 32 MB.");
            return read;
        }
        protected override void Dispose(bool disposing) { if (disposing) input.Dispose(); base.Dispose(disposing); }
        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => throw new NotSupportedException();
        public override long Position { get => consumed; set => throw new NotSupportedException(); }
        public override void Flush() { }
        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
    }
}