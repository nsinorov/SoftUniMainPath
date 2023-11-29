using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Theatre.Common;
using Theatre.Data.Enums;

namespace Theatre.DataProcessor.ExportDto;

[XmlType("Play")]
public class ExportPlayDto
{
    [XmlAttribute("Title")]
    public string Title { get; set; }

    [XmlAttribute("Duration")]
    public string Duration { get; set; }

    [XmlAttribute("Rating")]
    public string Rating { get; set; }

    [XmlAttribute("Genre")]
    public string Genre { get; set; }

    [XmlArray("Actors")]
    public ExportCastDto[] Actors { get; set; }
}

[XmlType("Actor")]
public class ExportCastDto
{
    [XmlAttribute("FullName")]
    public string FullName { get; set; }

    [XmlAttribute("MainCharacter")]
    public string IsMainCharacter { get; set; }
}