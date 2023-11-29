using Artillery.Common;
using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models;

public class Country
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.CountryNameMaxLength)]
    public string CountryName { get; set; }

    [Required]
    [Range(CommonConstraints.CountryArmySizeMinRange, CommonConstraints.CountryArmySizeMaxRange)]
    public int ArmySize { get; set; }

    //Collections
    public virtual ICollection<CountryGun> CountriesGuns { get; set; } = new HashSet<CountryGun>();
}