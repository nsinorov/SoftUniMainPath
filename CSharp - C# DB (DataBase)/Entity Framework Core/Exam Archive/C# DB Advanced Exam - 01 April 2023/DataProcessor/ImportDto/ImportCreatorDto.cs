using Boardgames.Common;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto;

[XmlType("Creator")]
public class ImportCreatorDto
{
    [XmlElement("FirstName")]
    [Required]
    [MinLength(CommonConstraints.CreatorNameMinLength)]
    [MaxLength(CommonConstraints.CreatorNameMaxLength)]
    public string FirstName { get; set; } = null!;

    [XmlElement("LastName")]
    [Required]
    [MinLength(CommonConstraints.CreatorNameMinLength)]
    [MaxLength(CommonConstraints.CreatorNameMaxLength)]
    public string LastName { get; set; } = null!;

    [XmlArray("Boardgames")]
    public ImportBoardgameDto[] Boardgames { get; set; } = null!;
}

[XmlType("Boardgame")]
public class ImportBoardgameDto
{
    [XmlElement("Name")]
    [Required]
    [MinLength(CommonConstraints.BoardgameNameMinLength)]
    [MaxLength(CommonConstraints.BoardgameNameMaxLength)]
    public string Name { get; set; } = null!;

    [XmlElement("Rating")]
    [Required]
    [Range(CommonConstraints.BoardgameRatingMinRange, CommonConstraints.BoardgameRatingMaxRange)]
    public double Rating { get; set; }

    [XmlElement("YearPublished")]
    [Required]
    [Range(CommonConstraints.BoardgameYearPublishedMinRange, CommonConstraints.BoardgameYearPublishedMaxRange)]
    public int YearPublished { get; set; }

    [XmlElement("CategoryType")]
    [Required]
    [Range(CommonConstraints.BoardgameCategoryTypeMinRange, CommonConstraints.BoardgameCategoryTypeMaxRange)]
    public int CategoryType { get; set; }

    [XmlElement("Mechanics")]
    [Required]
    public string Mechanics { get; set; } = null!;
}