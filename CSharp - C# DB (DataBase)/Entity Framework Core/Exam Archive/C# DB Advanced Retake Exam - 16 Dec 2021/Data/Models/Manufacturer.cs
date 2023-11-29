using Artillery.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models;

public class Manufacturer
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.ManufacturerNameMaxLength)]
    public string ManufacturerName { get; set; }

    [Required]
    [MaxLength(CommonConstraints.ManufacturerFoundedMaxLength)]
    public string Founded { get; set; }

    //Collections
    public virtual ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();
}