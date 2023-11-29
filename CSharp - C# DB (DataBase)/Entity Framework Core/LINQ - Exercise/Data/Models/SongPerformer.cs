using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class SongPerformer
{
	//Songs
	public int SongId { get; set; }

	[Required]
	[ForeignKey(nameof(SongId))]
	public Song Song { get; set; }


	//Performers
    public int PerformerId { get; set; }

    [ForeignKey(nameof(PerformerId))]
    [Required]
    public Performer Performer { get; set; }
}