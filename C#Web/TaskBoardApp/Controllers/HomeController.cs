using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskBoardAppDbContext _data;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            TaskBoardAppDbContext context)
        {
            _logger = logger;
            _data = context;
        }

        public async Task<ActionResult> Index()
        {
            var taskBoards = _data.Boards.Select(b => b.Name).Distinct();
            var tasksCounts = new List<HomeBoardModel>();
            foreach (var boardName in taskBoards)
            {
                var taskInBoard =
                    _data.Tasks.Where(t=>t.Board.Name == boardName).Count();
                tasksCounts.Add(new HomeBoardModel()
                {
                    BoardName = boardName,
                    TasksCount = taskInBoard

                });
            }
            var userTaksCount = -1;
            if (User.Identity.IsAuthenticated)
            {
                var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                userTaksCount = 
                    _data.Tasks.Where(t=>t.OwnerId == currentUserId).Count();
            }

            var homeModel = new HomeViewModel()
            {
                AllTasksCount = _data.Tasks.Count(),
                BoardsWithTasksCount = tasksCounts,
                UserTasksCount = userTaksCount
            };
            return View(homeModel);
        }

    }
}
