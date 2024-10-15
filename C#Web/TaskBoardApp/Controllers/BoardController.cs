﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data;
using TaskBoardApp.Models;
using TaskBoardApp.Views;

namespace TaskBoardApp.Controllers
{
    [Authorize]
    public class BoardController : Controller
    {
        private readonly TaskBoardAppDbContext data;
        public BoardController(TaskBoardAppDbContext context)
        {
            data = context;
        }
        public async Task<IActionResult> Index()
        {
            var boards = await data.Boards
                .Select(b => new BoardViewModel()
                {

                    Id = b.Id,
                    Name = b.Name,
                    Tasks = b.Tasks.Select(t => new TaskViewModel()
                    {
                        Id = t.Id,
                        CreatedOn = t.CreatedOn,
                        Description = t.Description,
                        Owner = t.Owner.UserName,
                        Title = t.Title,
                    })
                })
                .ToListAsync();

             return View(boards);
        }
    }
}