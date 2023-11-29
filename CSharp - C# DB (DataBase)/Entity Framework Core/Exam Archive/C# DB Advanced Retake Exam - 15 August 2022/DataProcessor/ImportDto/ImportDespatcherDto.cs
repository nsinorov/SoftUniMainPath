using System.ComponentModel.DataAnnotations;
using Trucks.Common;
using System.Xml.Serialization;

namespace Trucks.DataProcessor.ImportDto;

[XmlType("Despatcher")]
public class ImportDespatcherDto
{
    [XmlElement("Name")]
    [Required]
    [MinLength(CommonConstraints.DespatcherNameMinLength)]
    [MaxLength(CommonConstraints.DespatcherNameMaxLength)]
    public string Name { get; set; }

    [XmlElement("Position")]
    public string Position { get; set; }

    [XmlArray("Trucks")]
    public ImportTruckDto[] Trucks { get; set; }
}

[XmlType("Truck")]
public class ImportTruckDto
{
    [XmlElement("RegistrationNumber")]
    [RegularExpression(CommonConstraints.TruckRegistrationNumberRegex)]
    public string RegistrationNumber { get; set; }

    [XmlElement("VinNumber")]
    [Required]
    [MinLength(CommonConstraints.TruckVinNumberMinLength)]
    [MaxLength(CommonConstraints.TruckVinNumberMaxLength)]
    public string VinNumber { get; set; }

    [XmlElement("TankCapacity")]
    [Range(CommonConstraints.TruckTankCapacityMinRange, CommonConstraints.TruckTankCapacityMaxRange)]
    public int TankCapacity { get; set; }

    [XmlElement("CargoCapacity")]
    [Range(CommonConstraints.TruckCargoCapacityMinRange, CommonConstraints.TruckCargoCapacityMaxRange)]
    public int CargoCapacity { get; set; }

    [XmlElement("CategoryType")]
    [Required]
    [Range(CommonConstraints.TruckCategoryTypeMinRange, CommonConstraints.TruckCategoryTypeMaxRange)]
    public int CategoryType { get; set; }

    [XmlElement("MakeType")]
    [Required]
    [Range(CommonConstraints.TruckMakeTypeMinRange, CommonConstraints.TruckMakeTypeMaxRange)]
    public int MakeType { get; set; }
}