using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data;

public class StudentSystemContext : DbContext
{
	//Constructor
	public StudentSystemContext(DbContextOptions options) : base(options) { }

	//Properties (Tables)
	public DbSet<Student> Students { get; set; }
	public DbSet<Course> Courses { get; set; }
    public DbSet<Homework> Homeworks { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<StudentCourse> StudentsCourses { get; set; }

	//Methods
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Student>(s =>
		{
			s.HasKey(s => s.StudentId);
			s.Property(s => s.Name).HasMaxLength(100).IsUnicode(true).IsRequired(true);
			s.Property(s => s.PhoneNumber).HasMaxLength(10).IsUnicode(false).IsRequired(false);
			s.Property(s => s.RegisteredOn).IsRequired(true);
            s.Property(s => s.Birthday).IsRequired(false);
        });

		modelBuilder.Entity<Course>(c =>
		{
			c.HasKey(c => c.CourseId);
			c.Property(c => c.Name).IsUnicode(true).HasMaxLength(80).IsRequired(true);
            c.Property(c => c.Description).IsUnicode(true).IsRequired(false);
            c.Property(c => c.StartDate).IsRequired(true);
            c.Property(c => c.EndDate).IsRequired(true);
            c.Property(c => c.Price).IsRequired(true);
        });

		modelBuilder.Entity<Resource>(r =>
		{
			r.HasKey(r => r.ResourceId);
			r.Property(r => r.Name).HasMaxLength(50).IsUnicode(true).IsRequired(true);
			r.Property(r => r.Url).IsUnicode(false).IsRequired(true);
			 r.HasOne(r => r.Course).WithMany(c => c.Resources).HasForeignKey(r => r.CourseId);
        });

		modelBuilder.Entity<Homework>(h =>
		{
			h.HasKey(h => h.HomeworkId);
			h.Property(h => h.Content).IsUnicode(false).IsRequired(true);
            h.Property(h => h.SubmissionTime).IsRequired(true);
            h.Property(h => h.StudentId).IsRequired(true);
            h.Property(h => h.CourseId).IsRequired(true);

			h.HasOne(h => h.Course).WithMany(c => c.Homeworks).HasForeignKey(h => h.CourseId);
			h.HasOne(h => h.Student).WithMany(s => s.Homeworks).HasForeignKey(h => h.StudentId);
        });

		modelBuilder.Entity<StudentCourse>(sc =>
		{
			sc.HasKey(sc => new { sc.CourseId, sc.StudentId });

			sc.HasOne(sc => sc.Student).WithMany(s => s.StudentsCourses).HasForeignKey(sc => sc.StudentId);
            sc.HasOne(sc => sc.Course).WithMany(c => c.StudentsCourses).HasForeignKey(sc => sc.CourseId);
        });
	}
}