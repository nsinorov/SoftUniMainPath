using System.ComponentModel.DataAnnotations;
using Trucks.Common;

namespace Trucks.Data.Models;

public class Client
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.ClientNameMaxLength)]
    public string Name { get; set; }

    [Required]
    [MaxLength(CommonConstraints.ClientNationalityMaxLength)]
    public string Nationality { get; set; }

    [Required]
    public string Type { get; set; }

    //Collections
    public virtual ICollection<ClientTruck> ClientsTrucks { get; set; } = new HashSet<ClientTruck>();
}