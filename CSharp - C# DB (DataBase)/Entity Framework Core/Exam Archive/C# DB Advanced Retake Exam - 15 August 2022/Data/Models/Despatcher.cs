using System.ComponentModel.DataAnnotations;
using Trucks.Common;

namespace Trucks.Data.Models;

public class Despatcher
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.DespatcherNameMaxLength)]
    public string Name { get; set; }

    public string Position { get; set; }

    //Collections
    public virtual ICollection<Truck> Trucks { get; set; } = new HashSet<Truck>();
}