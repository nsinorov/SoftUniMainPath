using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class Album
{
    //Constructor
    public Album()
    {
        Songs = new HashSet<Song>();
    }

    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(40)]
    public string Name { get; set; }

    [Required]
    public DateTime ReleaseDate { get; set; }

    public decimal Price => Songs.Sum(s => s.Price);

    //Producer
    public int? ProducerId { get; set; }

    [ForeignKey(nameof(ProducerId))]
    public Producer Producer { get; set; }

    //Songs
    public ICollection<Song> Songs { get; set; }
}