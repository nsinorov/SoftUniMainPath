using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Trucks.Common;
using Trucks.Data.Models.Enums;

namespace Trucks.Data.Models;

public class Truck
{
    [Key]
    public int Id { get; set; }

    [RegularExpression(CommonConstraints.TruckRegistrationNumberRegex)]
    public string RegistrationNumber { get; set; }

    [Required]
    [MaxLength(CommonConstraints.TruckVinNumberMaxLength)]
    public string VinNumber { get; set; }

    [Range(CommonConstraints.TruckTankCapacityMinRange, CommonConstraints.TruckTankCapacityMaxRange)]
    public int TankCapacity { get; set; }

    [Range(CommonConstraints.TruckCargoCapacityMinRange, CommonConstraints.TruckCargoCapacityMaxRange)]
    public int CargoCapacity { get; set; }

    [Required]
    public CategoryType CategoryType { get; set; }

    [Required]
    public MakeType MakeType { get; set; }

    //Despatcher
    [Required]
    public int DespatcherId { get; set; }

    [ForeignKey(nameof(DespatcherId))]
    public Despatcher Despatcher { get; set; }

    //Collections
    public virtual ICollection<ClientTruck> ClientsTrucks { get; set; } = new HashSet<ClientTruck>();
}