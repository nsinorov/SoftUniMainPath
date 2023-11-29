using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto;

[XmlType("Creator")]
public class ExportCreatorDto
{
    [XmlAttribute("BoardgamesCount")]
    public int BoardgamesCount { get; set; }

    [XmlElement("CreatorName")]
    public string CreatorName { get; set; }

    //Collections
    [XmlArray("Boardgames")]
    public ExportBoardgameDto[] Boardgames { get; set; } = null!;
}

[XmlType("Boardgame")]
public class ExportBoardgameDto
{
    [XmlElement("BoardgameName")]
    public string BoardgameName { get; set; }

    [XmlElement("BoardgameYearPublished")]
    public int BoardgameYearPublished { get; set; }
}
