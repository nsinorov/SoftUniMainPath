using Artillery.Common;
using Artillery.Data.Enums;
using Artillery.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Artillery.DataProcessor.ImportDto;

public class ImportGunDto
{
    //Manufacturer
    [JsonProperty("ManufacturerId")]
    [Required]
    public int ManufacturerId { get; set; }

    [JsonProperty("GunWeight")]
    [Required]
    [Range(CommonConstraints.GunWeightMinRange, CommonConstraints.GunWeightMaxRange)]
    public int GunWeight { get; set; }

    [JsonProperty("BarrelLength")]
    [Required]
    [Range(CommonConstraints.BarrelLengthMinRange, CommonConstraints.BarrelLengthMaxRange)]
    public double BarrelLength { get; set; }

    [JsonProperty("NumberBuild")]
    public int? NumberBuild { get; set; }

    [JsonProperty("Range")]
    [Required]
    [Range(CommonConstraints.GunRangeMinRange, CommonConstraints.GunRangeMaxRange)]
    public int Range { get; set; }

    [JsonProperty("GunType")]
    [Required]
    public string GunType { get; set; }

    [JsonProperty("ShellId")]
    [Required]
    public int ShellId { get; set; }

    [JsonProperty("Countries")]
    public ImportCountryDto[] Countries { get; set; }
}

public class ImportCountryDto
{
    [JsonProperty("Id")]
    [Required]
    public int Id { get; set; }
}