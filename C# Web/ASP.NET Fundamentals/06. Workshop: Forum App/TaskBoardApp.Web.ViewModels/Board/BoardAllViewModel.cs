namespace TaskBoardApp.Web.ViewModels.Board
{
    using TaskBoardApp.Web.ViewModels.Task;
    public class BoardAllViewModel
    {
        public string Name { get; init; } = null!;
        public IEnumerable<TaskViewModel> Tasks { get; set; } = new List<TaskViewModel>();
    }
}