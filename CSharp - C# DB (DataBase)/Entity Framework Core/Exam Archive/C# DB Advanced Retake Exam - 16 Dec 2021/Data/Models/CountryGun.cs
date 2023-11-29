using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models;

public class CountryGun
{
    //Country
    [Required]
    public int CountryId { get; set; }

    [ForeignKey(nameof(CountryId))]
    public Country Country { get; set; }

    //Gun
    [Required]
    public int GunId { get; set; }

    [ForeignKey(nameof(GunId))]
    public Gun Gun { get; set; }
}