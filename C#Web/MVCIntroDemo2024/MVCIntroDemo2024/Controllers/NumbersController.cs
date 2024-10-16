﻿using Microsoft.AspNetCore.Mvc;

namespace MVCIntroDemo2024.Controllers
{
    public class NumbersController : Controller
    {
        private readonly ILogger _logger;
        public NumbersController(ILogger<NumbersController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            
            return View(50);
        }

        [HttpGet]
        public IActionResult Limit(int num)
        {
            return View("Index", num);
        }
    }
}
