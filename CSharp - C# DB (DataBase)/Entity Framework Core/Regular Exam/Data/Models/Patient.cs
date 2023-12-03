namespace Medicines.Data.Models;

using Medicines.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

public class Patient
{
    public Patient()
    {
        PatientsMedicines = new HashSet<PatientMedicine>(); 
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName  { get; set; } = null!;

    [Required]
    public AgeGroup AgeGroup { get; set; }

    [Required]
    public Gender Gender { get; set; }

    public virtual ICollection<PatientMedicine> PatientsMedicines { get; set; }
}
