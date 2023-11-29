using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models;

public class Position
{
    public Position()
    {
        Players = new HashSet<Player>();
    }

    [Key]
    public int PositionId { get; set; }

    [Required]
    public string Name { get; set; }

    public virtual ICollection<Player> Players { get; set; }
}