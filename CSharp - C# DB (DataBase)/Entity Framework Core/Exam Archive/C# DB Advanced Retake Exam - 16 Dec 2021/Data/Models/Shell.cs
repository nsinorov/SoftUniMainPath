using Artillery.Common;
using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models;

public class Shell
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [Range(CommonConstraints.ShellWeightMinRange, CommonConstraints.ShellWeightMaxRange)]
    public double ShellWeight { get; set; }

    [Required]
    [MaxLength(CommonConstraints.ShellCaliberMaxLength)]
    public string Caliber { get; set; }

    //Collections
    public virtual ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();
}