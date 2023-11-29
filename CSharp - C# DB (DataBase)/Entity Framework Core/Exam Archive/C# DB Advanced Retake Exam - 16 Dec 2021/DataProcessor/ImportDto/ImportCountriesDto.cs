using Artillery.Common;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto;

[XmlType("Country")]
public class ImportCountriesDto
{
    [XmlElement("CountryName")]
    [Required]
    [MinLength(CommonConstraints.CountryNameMinLength)]
    [MaxLength(CommonConstraints.CountryNameMaxLength)]
    public string CountryName { get; set; }

    [XmlElement("ArmySize")]
    [Required]
    [Range(CommonConstraints.CountryArmySizeMinRange, CommonConstraints.CountryArmySizeMaxRange)]
    public int ArmySize { get; set; }
}