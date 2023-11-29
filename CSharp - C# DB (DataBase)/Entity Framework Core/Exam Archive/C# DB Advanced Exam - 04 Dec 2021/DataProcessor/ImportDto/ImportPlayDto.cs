using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Theatre.Common;

namespace Theatre.DataProcessor.ImportDto;

[XmlType("Play")]
public class ImportPlayDto
{
    [XmlElement("Title")]
    [Required]
    [MinLength(CommonConstraints.PlayTitleMinLength)]
    [MaxLength(CommonConstraints.PlayTitleMaxLength)]
    public string Title { get; set; }

    [XmlElement("Duration")]
    [Required]
    //[Range(typeof(TimeSpan), CommonConstraints.PlayDurationMinLengthInHours, CommonConstraints.PlayDurationMaxLengthInHours)]
    public string Duration { get; set; }

    [XmlElement("Raiting")]
    [Required]
    [Range(CommonConstraints.PlayRatingMinRange, CommonConstraints.PlayRatingMaxRange)]
    public double Rating { get; set; }

    [XmlElement("Genre")]
    [Required]
    //[Range(CommonConstraints.PlayGenreMinRange, CommonConstraints.PlayGenreMaxRange)]
    public string Genre { get; set; }

    [XmlElement("Description")]
    [Required]
    [MaxLength(CommonConstraints.PlayDescriptionMaxLength)]
    public string Description { get; set; }

    [XmlElement("Screenwriter")]
    [Required]
    [MinLength(CommonConstraints.PlayScreenwriterMinLength)]
    [MaxLength(CommonConstraints.PlayScreenwriterMaxLength)]
    public string Screenwriter { get; set; }
}