using Artillery.Common;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto;

[XmlType("Shell")]
public class ImportShellDto
{
    [XmlElement("ShellWeight")]
    [Required]
    [Range(CommonConstraints.ShellWeightMinRange, CommonConstraints.ShellWeightMaxRange)]
    public double ShellWeight { get; set; }

    [XmlElement("Caliber")]
    [Required]
    [MinLength(CommonConstraints.ShellCaliberMinLength)]
    [MaxLength(CommonConstraints.ShellCaliberMaxLength)]
    public string Caliber { get; set; }
}