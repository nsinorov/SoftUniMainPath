using System.ComponentModel.DataAnnotations;

namespace MusicHub.Data.Models
{
    public class Producer
    {
        //Constructor
        public Producer()
        {
            Albums = new HashSet<Album>();
        }

        //Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Pseudonym { get; set; }

        public string PhoneNumber { get; set; }

        //Albums
        public virtual ICollection<Album> Albums { get; set; }
    }
}