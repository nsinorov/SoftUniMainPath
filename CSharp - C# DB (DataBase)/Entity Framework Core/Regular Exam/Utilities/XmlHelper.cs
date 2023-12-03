namespace Medicines.Utilities;

using System.Text;
using System.Xml.Serialization;


public class XmlHelper
{
    // ADDING XMLHELPER IN ORDER TO SOLVE 3RD PROBLEM
    public T Deserialize<T>(string inputXml, string rootName)
    {
        XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
        XmlSerializer xmlSeriliazer =
            new XmlSerializer(typeof(T), xmlRoot);

        using StringReader reader = new StringReader(inputXml);

        T dtos = (T)xmlSeriliazer.Deserialize(reader);

        return dtos;
    }

    public string Serialize<T>(T dtos, string rootName)
    {
        XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
        XmlSerializer xmlSeriliazer = new XmlSerializer(typeof(T), xmlRoot);

        XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        namespaces.Add(string.Empty, string.Empty);

        StringBuilder sb = new StringBuilder();

        using StringWriter writer = new StringWriter(sb);
        xmlSeriliazer.Serialize(writer, dtos, namespaces);

        return sb.ToString().TrimEnd();
    }
}
