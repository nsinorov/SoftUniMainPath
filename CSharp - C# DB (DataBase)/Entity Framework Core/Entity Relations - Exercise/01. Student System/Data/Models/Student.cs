namespace P01_StudentSystem.Data.Models;

public class Student
{
    //Constructor
    public Student()
    {
        StudentsCourses = new HashSet<StudentCourse>();
        Homeworks = new HashSet<Homework>();
    }

    //Properties
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime RegisteredOn { get; set; }
    public DateTime? Birthday { get; set; }
    public ICollection<StudentCourse> StudentsCourses { get; set; }
    public ICollection<Homework> Homeworks { get; set; }
}