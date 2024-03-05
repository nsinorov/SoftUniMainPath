namespace TaskBoardApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Task = TaskBoardApp.Data.Models.Task;
    public class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasOne(t => t.Board)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.BoardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateTasks());
        }

        private ICollection<Task> GenerateTasks()
        {
            ICollection<Task> tasks = new HashSet<Task>();
            Task currentTask;

            currentTask = new Task()
            {
                Title = "Improve CSS Styles",
                Description = "Implement better styling for all public pages",
                CreatedOn = DateTime.Now.AddDays(-200),
                OwnerId = "e56c79c6-fff2-496b-828b-c89b0a6f9891",
                BoardId = 1
            };
            tasks.Add(currentTask);


            currentTask = new Task()
            {
                Title = "Android Client App",
                Description = "Create Android client app for the RESTful API",
                CreatedOn = DateTime.Now.AddMonths(-5),
                OwnerId = "16ffcce9-8ef4-4e71-93ae-d361009cc50f",
                BoardId = 1
            };
            tasks.Add(currentTask);

            currentTask = new Task()
            {
                Title = "Desktop Client App",
                Description = "Create Windows Forms desktop app client for the TaskBoard RESTful API",
                CreatedOn = DateTime.Now.AddMonths(-1),
                OwnerId = "16ffcce9-8ef4-4e71-93ae-d361009cc50f",
                BoardId = 2
            };
            tasks.Add(currentTask);

            currentTask = new Task()
            {
                Title = "Create Tasks",
                Description = "Implement [Create Task] page for adding new tasks",
                CreatedOn = DateTime.Now.AddYears(-1),
                OwnerId = "e56c79c6-fff2-496b-828b-c89b0a6f9891",
                BoardId = 3
            };
            tasks.Add(currentTask);

            return tasks;
        }
    }
}