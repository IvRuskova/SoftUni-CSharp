using Homies.Data;
using Homies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homies.Controllers
{
    public class EventController : Controller
    {
        private readonly HomiesDbContext _data;
        public EventController(HomiesDbContext context)
        {
            _data = context;
        }
        public async Task<IActionResult> All()
        {
            var events = await _data.Events
                .Select(e=> new EventInfoViewModel(
                    e.Id,
                    e.Name,
                    e.Start,
                    e.Type.Name,
                    e.Organaser.UserName
                    ))
                .ToListAsync();
            return View(events);
        }
    }
}
