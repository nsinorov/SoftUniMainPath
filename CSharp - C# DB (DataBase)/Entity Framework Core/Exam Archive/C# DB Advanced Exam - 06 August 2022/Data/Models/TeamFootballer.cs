using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Footballers.Data.Models;

public class TeamFootballer
{
    //Team
    [Required]
    public int TeamId { get; set; }

    [ForeignKey(nameof(TeamId))]
    public Team Team { get; set; }

    //Footballer
    [Required]
    public int FootballerId { get; set; }

    [ForeignKey(nameof(FootballerId))]
    public Footballer Footballer { get; set; }
}