using Artillery.Common;
using Artillery.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artillery.Data.Models;

public class Gun
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [Range(CommonConstraints.GunWeightMinRange, CommonConstraints.GunWeightMaxRange)]
    public int GunWeight { get; set; }

    [Required]
    [Range(CommonConstraints.BarrelLengthMinRange, CommonConstraints.BarrelLengthMaxRange)]
    public double BarrelLength { get; set; }

    public int? NumberBuild { get; set; }

    [Required]
    [Range(CommonConstraints.GunRangeMinRange, CommonConstraints.GunRangeMaxRange)]
    public int Range { get; set; }

    [Required]
    public GunType GunType { get; set; }

    //Manufacturer
    [Required]
    public int ManufacturerId { get; set; }

    [ForeignKey(nameof(ManufacturerId))]
    public Manufacturer Manufacturer { get; set; }

    //Shell
    [Required]
    public int ShellId { get; set; }

    [ForeignKey(nameof(ShellId))]
    public Shell Shell { get; set; }

    //Collections
    public virtual ICollection<CountryGun> CountriesGuns { get; set; } = new HashSet<CountryGun>();
}