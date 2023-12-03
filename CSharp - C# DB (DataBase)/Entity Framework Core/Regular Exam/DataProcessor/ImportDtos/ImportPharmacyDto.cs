using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Medicines.DataProcessor.ImportDtos;

[XmlType("Pharmacy")]
public class ImportPharmacyDto
{
    [XmlAttribute("non-stop")]
    [Required]
    public string IsNonStop { get; set; } = null!;

    [XmlElement("Name")]
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string Name { get; set; } = null!;

    [XmlElement("PhoneNumber")]
    [Required]
    [MinLength(14)]
    [MaxLength(14)]
    [RegularExpression("^\\(\\d{3}\\) \\d{3}-\\d{4}$")]
    public string PhoneNumber { get; set; } = null!;

    [XmlArray("Medicines")]
    public ImportMedicineDto[] Medicines { get; set; } = null!;
}
