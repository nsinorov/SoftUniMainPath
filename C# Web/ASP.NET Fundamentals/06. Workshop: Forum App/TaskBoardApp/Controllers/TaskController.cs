namespace TaskBoardApp.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Security.Claims;
    using TaskBoardApp.Data;
    using TaskBoardApp.Data.Models;
    using TaskBoardApp.Web.ViewModels.Task;

    [Authorize]
    public class TaskController : Controller
    {
        private readonly TaskBoardDbContext dbContext;

        public TaskController(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Create()
        {
            TaskFormModel taskModel = new TaskFormModel()
            {
                Boards = GetBoards()
            };
            return View(taskModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskFormModel taskModel)
        {
            if (!GetBoards().Any(b => b.Id == taskModel.BoardId))
            {
                ModelState.AddModelError(nameof(taskModel.BoardId), "Board does not exist.");
            }

            string currentUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                taskModel.Boards = GetBoards();
                return View(taskModel);
            }

            Task task = new Task()
            {
                Title = taskModel.Title,
                Description = taskModel.Description,
                CreatedOn = DateTime.Now,
                BoardId = taskModel.BoardId,
                OwnerId = currentUserId
            };

            await dbContext.Tasks.AddAsync(task);
            await dbContext.SaveChangesAsync();

            var boards = dbContext.Boards;

            return RedirectToAction("All", "Board");
        }

        public async Task<IActionResult> Details(string id)
        {
            var task = await dbContext.Tasks
                .Where(t => t.Id.ToString() == id)
                .Select(t => new TaskDetailsViewModel()
                {
                    Id = t.Id.ToString(),
                    Title = t.Title,
                    Description=t.Description,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    Board = t.Board.Name,
                    Owner = t.Owner.UserName
                })
                .FirstOrDefaultAsync();

            if (task == null)
            {
                return BadRequest();
            }

            return View(task);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var task = dbContext.Tasks.Where(t => t.Id.ToString() == id).First();

            if (task == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != task.OwnerId)
            {
                return Unauthorized();
            }

            TaskFormModel taskModel = new TaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                Boards = GetBoards()
            };

            return View(taskModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, TaskFormModel taskModel)
        {
            var task = dbContext.Tasks.Where(t => t.Id.ToString() == id).First();

            if (task == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != task.OwnerId)
            {
                return Unauthorized();
            }

            if (!GetBoards().Any(b => b.Id == taskModel.BoardId))
            {
                ModelState.AddModelError(nameof(taskModel.BoardId), "Board does not exist.");
            }

            if (!ModelState.IsValid)
            {
                taskModel.Boards = GetBoards();

                return View(taskModel);
            }

            task.Title = taskModel.Title;
            task.Description = taskModel.Description;
            task.BoardId = taskModel.BoardId;

            await dbContext.SaveChangesAsync();
            return RedirectToAction("All", "Board");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var task = dbContext.Tasks.Where(t => t.Id.ToString() == id).First();

            if (task == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != task.OwnerId)
            {
                return Unauthorized();
            }

            TaskViewModel taskModel = new TaskViewModel()
            {
                Id = task.Id.ToString(),
                Title = task.Title,
                Description = task.Description
            };

            return View(taskModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TaskViewModel taskModel)
        {
            var task = dbContext.Tasks.Where(t => t.Id.ToString() == taskModel.Id).First();

            if (task == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != task.OwnerId)
            {
                return Unauthorized();
            }

            dbContext.Tasks.Remove(task);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("All", "Board");
        }

        private IEnumerable<TaskBoardModel> GetBoards()
        {
            var boards = dbContext.Boards
                .Select(b => new TaskBoardModel()
                { 
                    Id = b.Id,
                    Name = b.Name
                });
            return boards;
        }

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}