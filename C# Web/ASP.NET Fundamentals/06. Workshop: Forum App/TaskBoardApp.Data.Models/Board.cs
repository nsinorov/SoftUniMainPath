namespace TaskBoardApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static TaskBoardApp.Common.EntityValidationConstants.Board;
    public class Board
    {
        public Board()
        {
            Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(BoardMaxName)]
        public string Name { get; set; } = null!;

        public ICollection<Task> Tasks { get; set; } = null!;
    }
}