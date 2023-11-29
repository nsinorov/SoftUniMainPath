using Artillery.Common;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto;

[XmlType("Manufacturer")]
public class ImportManufacturerDto
{
    [XmlElement("ManufacturerName")]
    [Required]
    [MinLength(CommonConstraints.ManufacturerNameMinLength)]
    [MaxLength(CommonConstraints.ManufacturerNameMaxLength)]
    public string ManufacturerName { get; set; }

    [XmlElement("Founded")]
    [Required]
    [MinLength(CommonConstraints.ManufacturerFoundedMinLength)]
    [MaxLength(CommonConstraints.ManufacturerFoundedMaxLength)]
    public string Founded { get; set; }
}