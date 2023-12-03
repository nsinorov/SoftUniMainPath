using System.Xml.Serialization;

namespace Medicines.DataProcessor.ExportDtos;

[XmlType("Patient")]
public class ExportPatientDto
{
    [XmlAttribute("Gender")]
    public string Gender { get; set; } = null!;

    [XmlElement("Name")]
    public string FullName { get; set; } = null!;

    [XmlElement("AgeGroup")]
    public string AgeGroup { get; set; } = null!;

    [XmlArray("Medicines")]
    public ExportMedicineDto[] Medicines { get; set; } = null!;
}
