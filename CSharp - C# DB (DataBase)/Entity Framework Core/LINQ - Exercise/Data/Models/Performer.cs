using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class Performer
{
    //Constructor
    public Performer()
    {
        PerformerSongs = new HashSet<SongPerformer>();
    }

    //Properties
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(20)]
    public string LastName { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public decimal NetWorth { get; set; }

    //Songs
    public ICollection<SongPerformer> PerformerSongs { get; set; }
}