using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Theatre.Common;

namespace Theatre.DataProcessor.ImportDto;

[XmlType("Cast")]
public class ImportCastDto
{
    [XmlElement("FullName")]
    [Required]
    [MinLength(CommonConstraints.CastFullNameMinLength)]
    [MaxLength(CommonConstraints.CastFullNameMaxLength)]
    public string FullName { get; set; }

    [XmlElement("IsMainCharacter")]
    [Required]
    public bool IsMainCharacter { get; set; }

    [XmlElement("PhoneNumber")]
    [Required]
    [RegularExpression(CommonConstraints.CastPhoneNumberRegex)]
    public string PhoneNumber { get; set; }

    [XmlElement("PlayId")]
    [Required]
    public int PlayId { get; set; }
}