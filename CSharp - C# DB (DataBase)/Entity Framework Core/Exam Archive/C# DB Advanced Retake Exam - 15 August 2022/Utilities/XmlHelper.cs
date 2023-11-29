using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Trucks.Utilities;

public class XmlHelper
{
    public T Deserialize<T>(string inputXml, string rootName)
    {
        XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
        XmlSerializer xmlSerializer =
            new XmlSerializer(typeof(T), xmlRoot);

        using StringReader reader = new StringReader(inputXml);
        T deserializedDtos =
            (T)xmlSerializer.Deserialize(reader);

        return deserializedDtos;
    }

    public string Serialize<T>(T obj, string rootName)
    {
        StringBuilder sb = new StringBuilder();

        XmlRootAttribute xmlRoot =
            new XmlRootAttribute(rootName);
        XmlSerializer xmlSerializer =
            new XmlSerializer(typeof(T), xmlRoot);

        XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        namespaces.Add(string.Empty, string.Empty);

        XmlWriterSettings settings = new XmlWriterSettings
        {
            Indent = true
        };

        using (StringWriter writer = new StringWriter(sb))
        using (XmlWriter xmlWriter = XmlWriter.Create(writer, settings))
        {
            xmlSerializer.Serialize(xmlWriter, obj, namespaces);
        }

        return sb.ToString().TrimEnd();
    }
}