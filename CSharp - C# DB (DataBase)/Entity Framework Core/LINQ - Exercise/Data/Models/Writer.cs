using System.ComponentModel.DataAnnotations;

namespace MusicHub.Data.Models;

public class Writer
{
    //Constructor
    public Writer()
    {
        Songs = new HashSet<Song>();
    }

    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Name { get; set; }
    public string Pseudonym { get; set; }

    //Songs
    public ICollection<Song> Songs { get; set; }
}