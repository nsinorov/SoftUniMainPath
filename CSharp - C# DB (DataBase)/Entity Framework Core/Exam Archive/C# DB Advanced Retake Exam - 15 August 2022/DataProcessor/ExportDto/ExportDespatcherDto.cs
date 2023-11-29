using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Trucks.Common;
using Trucks.Data.Models.Enums;

namespace Trucks.DataProcessor.ExportDto;

[XmlType("Despatcher")]
public class ExportDespatcherDto
{
    [XmlAttribute("TrucksCount")]
    public int TrucksCount { get; set; }

    [XmlElement("DespatcherName")]
    public string Name { get; set; }

    [XmlArray("Trucks")]
    public ExportTruckDto[] Trucks { get; set; }
}

[XmlType("Truck")]
public class ExportTruckDto
{
    [XmlElement("RegistrationNumber")]
    public string RegistrationNumber { get; set; }

    [XmlElement("Make")]
    public string MakeType { get; set; }
}