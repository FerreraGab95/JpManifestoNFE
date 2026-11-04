using System.Collections.Concurrent;
using System.Xml;
using System.Xml.Serialization;
namespace JpManifestoNFE;
public class XmlHelper
{
    private static readonly ConcurrentDictionary<Type, XmlSerializer> Serializers = new();
    private static XmlSerializer Serializer(Type type) => Serializers.GetOrAdd(type, t => new XmlSerializer(t));
    public static XmlDocument ParseToXmlDocument(object value, Type type, string defaultNamespace)
    {
        var namespaces = new XmlSerializerNamespaces();
        namespaces.Add("", defaultNamespace);
        var document = new XmlDocument { XmlResolver = null };
        using (var writer = document.CreateNavigator()!.AppendChild())
            Serializer(type).Serialize(writer, value, namespaces);
        return document;
    }
    public static T ParseFromXml<T>(XmlNode node, Type type)
    {
        ArgumentNullException.ThrowIfNull(node);
        using var reader = new XmlNodeReader(node);
        return (T)(Serializer(type).Deserialize(reader) ?? throw new InvalidDataException("XML de retorno vazio."));
    }
    public static T ParseFromXml<T>(XmlDocument document, Type type) => ParseFromXml<T>((XmlNode)document, type);
}