using Footballers.Common;
using System.ComponentModel.DataAnnotations;

namespace Footballers.Data.Models;

public class Coach
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.CoachNameMaxLength)]
    public string Name { get; set; }

    [Required]
    public string Nationality { get; set; }

    //Collections
    public virtual ICollection<Footballer> Footballers { get; set; } = new HashSet<Footballer>();
}