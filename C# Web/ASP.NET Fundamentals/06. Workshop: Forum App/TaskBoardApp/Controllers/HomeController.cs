namespace TaskBoardApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using TaskBoardApp.Data;
    using TaskBoardApp.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly TaskBoardDbContext dbContext;

        public HomeController(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var taskBoards = dbContext.Boards
                .Select(b => b.Name)
                .Distinct();

            var tasksCounts = new List<HomeBoardModel>();

            foreach (var boardName in taskBoards)
            {
                var tasksInBoard = dbContext.Tasks.Where(t => t.Board.Name == boardName).Count();

                tasksCounts.Add(new HomeBoardModel()
                {
                    BoardName = boardName,
                    TasksCount = tasksInBoard
                });
            }

            var userTasksCount = -1;

            if (User.Identity.IsAuthenticated)
            {
                var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                userTasksCount = dbContext.Tasks.Where(t => t.OwnerId == currentUserId).Count();
            }

            var homeModel = new HomeViewModel()
            {
                AllTasksCount = dbContext.Tasks.Count(),
                BoardsWithTasksCount = tasksCounts,
                UserTasksCount = userTasksCount
            };

            return View(homeModel);
        }
    }
}