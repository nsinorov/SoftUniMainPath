using Footballers.Common;
using Footballers.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Footballers.Data.Models;

public class Footballer
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.FootballerNameMaxLength)]
    public string Name { get; set; }

    [Required]
    public DateTime ContractStartDate { get; set; }

    [Required]
    public DateTime ContractEndDate { get; set; }

    [Required]
    public PositionType PositionType { get; set; }

    [Required]
    public BestSkillType BestSkillType { get; set; }

    //Coach
    [Required]
    public int CoachId { get; set; }

    [ForeignKey(nameof(CoachId))]
    public Coach Coach { get; set; }

    //Collections
    public virtual ICollection<TeamFootballer> TeamsFootballers { get; set; } = new HashSet<TeamFootballer>();
}