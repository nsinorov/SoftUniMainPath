using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class Player
{
    public Player()
    {
        PlayersStatistics = new HashSet<PlayerStatistic>();
    }

    [Key]
    public int PlayerId { get; set; }

    [Required]
    public string Name { get; set; }

    public int SquadNumber { get; set; }


    public int TeamId { get; set; }

    [ForeignKey(nameof(TeamId))]
    public virtual Team Team { get; set; }


    public int PositionId { get; set; }

    [ForeignKey(nameof(PositionId))]
    public virtual Position Position { get; set; }


    public bool IsInjured { get; set; }

    public ICollection<PlayerStatistic> PlayersStatistics { get; set; }
}