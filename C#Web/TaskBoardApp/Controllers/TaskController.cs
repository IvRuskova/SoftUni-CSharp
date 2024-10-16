using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models;
using TaskBoardApp.Views;

namespace TaskBoardApp.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly TaskBoardAppDbContext data;
        public TaskController(TaskBoardAppDbContext context)
        {
            data = context;
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new TaskFormViewModel();
            model.Boards = await GetBoards();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskFormViewModel model)
        {
            if(!(await GetBoards()).Any(b=>b.Id == model.BoardId))
            {
                ModelState.AddModelError(nameof(model.BoardId), "Board does not exist");
            }
            if (!ModelState.IsValid)
            {
                model.Boards = await GetBoards();
                return View(model);
            }
            var entity = new Data.Task() 
            { 
                BoardId = model.BoardId,    
                CreatedOn = DateTime.Now,
                Description = model.Description,
                OwnerId = GetUserId(),
                Title = model.Title
            };
            await data.AddAsync(entity);
            await data.SaveChangesAsync();

            return RedirectToAction("Index", "Board");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var task = await data.Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskDetailsViewModel()
                {
                    Board = t.Board.Name,
                    Description = t.Description,
                    Id = t.Id,
                    CreatedOn = t.CreatedOn != null && t.CreatedOn.HasValue
                    ? t.CreatedOn.Value.ToString("dd.MM.yyyy HH:mm")
                    : "",
                    Owner = t.Owner.UserName,
                    Title = t.Title

                }).FirstOrDefaultAsync();
            return View(task);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            var task = await data.Tasks.FindAsync(id);
            if (task == null)
            {
                return BadRequest();
            }
            string currentUserId = GetUserId();
            if (task.OwnerId != currentUserId)
            {
                return Unauthorized();
            }
            var model = new TaskDetailsViewModel()
            {
                BoardId = task.BoardId,
                Description = task.Description,
                Id = task.Id,
                Boards = await GetBoards()
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id, TaskFormViewModel taskModel)
        {
            var task = await data.Tasks.FindAsync(id);
            if (task == null)
            {
                return BadRequest();
            }
            string currentUserId = GetUserId();
            if (task.OwnerId != currentUserId)
            {
                return Unauthorized();
            }
            if (!GetBoards().Any(b=>b.Id == taskModel.BoardId))
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
            await data.SaveChangesAsync();
            return RedirectToAction("All", "Board");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var task = await data.Tasks.FindAsync(id);
            if (task == null) {
                return BadRequest();
            }
            string currentUserId = GetUserId();
            if (task.OwnerId != currentUserId)
            {
                return Unauthorized();
            }
            TaskViewModel taskViewModel = new TaskViewModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
            };
            return View(taskViewModel);
        }
        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        private async  Task<IEnumerable<TaskBoardViewModel>> GetBoards()
        {
           return await data.Boards.Select(x => new TaskBoardViewModel 
           { 
               Id = x.Id,
               Name = x.Name,
           }).ToListAsync();
        }
    }
}
