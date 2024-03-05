namespace TaskBoardApp.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;
    using TaskBoardApp.Data.Models;
    using Task = TaskBoardApp.Data.Models.Task;

    public class TaskBoardDbContext : IdentityDbContext<IdentityUser>
    {
        //Constructor
        public TaskBoardDbContext(DbContextOptions<TaskBoardDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        //Properties (Tables)
        public DbSet<Task> Tasks { get; set; } = null!;
        public DbSet<Board> Boards { get; set; } = null!;

        //Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(TaskBoardDbContext)) ?? Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}