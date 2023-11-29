using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Utilities;

public class XmlParser
{
    public T Deserialize<T>(string inputXml, string rootName)
    {
        using StringReader reader = new(inputXml);
        XmlRootAttribute xmlRoot = new(rootName);
        XmlSerializer serializer = new(typeof(T), xmlRoot);

        return (T)serializer.Deserialize(reader)!;
    }

    public string Serialize<T>(T obj, string rootName)
    {
        StringBuilder sb = new();

        XmlRootAttribute xmlRoot =new(rootName);
        XmlSerializerNamespaces xmlNamespace = new();
        xmlNamespace.Add(string.Empty, string.Empty);

        StringWriter writer = new(sb);
        XmlSerializer serializer = new(typeof(T), xmlRoot);
        serializer.Serialize(writer, obj, xmlNamespace);

        return sb.ToString().TrimEnd();
    }
}