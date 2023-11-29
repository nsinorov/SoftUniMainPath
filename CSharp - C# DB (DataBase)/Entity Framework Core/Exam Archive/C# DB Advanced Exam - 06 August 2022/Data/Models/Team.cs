using Footballers.Common;
using System.ComponentModel.DataAnnotations;

namespace Footballers.Data.Models;

public class Team
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [RegularExpression(CommonConstraints.TeamNameRegex)]
    public string Name { get; set; }

    [Required]
    [MaxLength(CommonConstraints.TeamNationalityMaxLength)]
    public string Nationality { get; set; }

    [Required]
    public int Trophies { get; set; }

    //Collections
    public virtual ICollection<TeamFootballer> TeamsFootballers { get; set; } = new HashSet<TeamFootballer>();
}