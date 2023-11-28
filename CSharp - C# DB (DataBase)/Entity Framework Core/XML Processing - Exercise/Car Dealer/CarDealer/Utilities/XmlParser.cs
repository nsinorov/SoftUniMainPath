using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Utilities;

public class XmlParser
{
    public T Deserialize<T>(string inputXml, string rootName)
    {
        XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xmlRoot);

        using StringReader reader = new StringReader(inputXml);
        T deserializedObj = (T)xmlSerializer.Deserialize(reader);

        return deserializedObj;
    }

    public T[] DeserializeCollection<T>(string inputXml, string rootName)
    {
        XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T[]), xmlRoot);

        using StringReader reader = new StringReader(inputXml);
        T[] deserializedObj = (T[])xmlSerializer.Deserialize(reader);

        return deserializedObj;
    }

    public string Serialize<T>(T obj, string rootName)
    {
        XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(rootName);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xmlRootAttribute);

        XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        namespaces.Add(string.Empty, string.Empty);

        StringBuilder sb = new StringBuilder();
        using StringWriter writer = new StringWriter(sb);

        xmlSerializer.Serialize(writer, obj, namespaces);
        return sb.ToString().TrimEnd();
    }

    public string Serialize<T>(T[] obj, string rootName)
    {
        XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(rootName);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T[]), xmlRootAttribute);

        XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        namespaces.Add(string.Empty, string.Empty);

        StringBuilder sb = new StringBuilder();
        using StringWriter writer = new StringWriter(sb);

        xmlSerializer.Serialize(writer, obj, namespaces);
        return sb.ToString().TrimEnd();
    }
}