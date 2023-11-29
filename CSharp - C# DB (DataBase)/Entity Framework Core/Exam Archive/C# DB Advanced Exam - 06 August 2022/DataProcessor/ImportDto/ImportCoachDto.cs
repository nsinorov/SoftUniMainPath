using Footballers.Common;
using Footballers.Data.Enums;
using Footballers.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ImportDto;

[XmlType("Coach")]
public class ImportCoachDto
{
    [Required]
    [MinLength(CommonConstraints.CoachNameMinLength)]
    [MaxLength(CommonConstraints.CoachNameMaxLength)]
    public string Name { get; set; }

    [Required]
    public string Nationality { get; set; }

    [XmlArray("Footballers")]
    public ImportFootballerDto[] Footballers { get; set; }
}

[XmlType("Footballer")]
public class ImportFootballerDto
{
    [XmlElement("Name")]
    [Required]
    [MinLength(CommonConstraints.FootballerNameMinLength)]
    [MaxLength(CommonConstraints.FootballerNameMaxLength)]
    public string Name { get; set; }

    [XmlElement("ContractStartDate")]
    [Required]
    public string ContractStartDate { get; set; }

    [XmlElement("ContractEndDate")]
    [Required]
    public string ContractEndDate { get; set; }

    [XmlElement("BestSkillType")]
    [Required]
    [Range(CommonConstraints.FootballerBestSkillMinRange, CommonConstraints.FootballerBestSkillMaxRange)]
    public int BestSkillType { get; set; }

    [XmlElement("PositionType")]
    [Required]
    [Range(CommonConstraints.FootballerPositionMinRange, CommonConstraints.FootballerPositionMaxRange)]
    public int PositionType { get; set; }
}