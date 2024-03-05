namespace TaskBoardApp.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using TaskBoardApp.Data;
    using TaskBoardApp.Web.ViewModels.Board;
    using TaskBoardApp.Web.ViewModels.Task;

    [Authorize]
    public class BoardController : Controller
    {

        private readonly TaskBoardDbContext dbContext;

        public BoardController(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> All()
        {
            var boards = await dbContext
                .Boards
                .Select(b => new BoardAllViewModel()
                {
                    Name = b.Name,
                    Tasks = b.Tasks
                    .Select(t => new TaskViewModel()
                    {
                        Id = t.Id.ToString(),
                        Title = t.Title,
                        Description = t.Description,
                        Owner = t.Owner.UserName
                    })
                }).ToListAsync();

            return View(boards);
        }
    }
}
