using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Medicines.DataProcessor.ImportDtos;

[XmlType("Medicine")]
public class ImportMedicineDto
{
    [XmlAttribute("category")]
    [Required]
    [Range(0, 4)]
    public int Category { get; set; }

    [XmlElement("Name")]
    [Required]
    [MinLength(3)]
    [MaxLength(150)]
    public string Name { get; set; } = null!;

    [XmlElement("Price")]
    [Required]
    [Range(0.01, 1000.00)]
    public decimal Price { get; set; }

    [XmlElement("ProductionDate")]
    [Required]
    public string ProductionDate { get; set; } = null!;

    [XmlElement("ExpiryDate")]
    [Required]
    public string ExpiryDate { get; set; } = null!;

    [XmlElement("Producer")]
    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    public string Producer { get; set; } = null!;
}