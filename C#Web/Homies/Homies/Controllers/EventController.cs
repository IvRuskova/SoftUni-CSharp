using Homies.Data;
using Homies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Security.Claims;

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
                .AsNoTracking()
                .Select(e => new EventInfoViewModel(
                    e.Id,
                    e.Name,
                    e.Start,
                    e.Type.Name,
                    e.Organaser.UserName
                    ))
                .ToListAsync();
            return View(events);
        }
        public async Task<IActionResult> Join(int id)
        {
            var e = await _data.Events
                .Where(e => e.Id == id)
                .Include(e => e.EventsParticipants)
                .FirstOrDefaultAsync();

            if (e == null)
            {
                return BadRequest();
            }
            string userId = GetUserId();
            if (!e.EventsParticipants.Any(p => p.HelperId == userId))
            {
                e.EventsParticipants.Add(new EventParticipant()
                {
                    EventId = e.Id,
                    HelperId = userId
                });
            }

            return RedirectToAction(nameof(Joined));
        }

        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            string userId = GetUserId();    

            var model = await _data.EventParticipants
                .Where(ep => ep.HelperId == userId)
                .AsNoTracking()
                .Select(ep => new EventInfoViewModel(
                    ep.EventId,
                    ep.Event.Name,
                    ep.Event.Start,
                    ep.Event.Type.Name,
                    ep.Event.Organaser.UserName
                    ))
                .ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> Leave(int id)
        {
            var e = await _data.Events
                .Where(e => e.Id == id)
                .Include(e => e.EventsParticipants)
                .FirstOrDefaultAsync();

            if (e == null)
            {
                return BadRequest();
            }
            string userId = GetUserId();

            var ep = e.EventsParticipants
                .FirstOrDefault(ep => ep.HelperId == userId);

            if (ep == null)
            {
                return BadRequest();
            }

            e.EventsParticipants.Remove(ep);
            await _data.SaveChangesAsync();
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new EventFormViewModel();
            model.Types = await GetTypes();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventFormViewModel model)
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;

            if (DateTime.TryParseExact(
            model.Start,
            DataConstants.DateFomat,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out start))
            {
                ModelState.AddModelError(nameof(model.Start),
                    $"Invalid date!Formast must be: {DataConstants.DateFomat}");
            };

            if (DateTime.TryParseExact(
            model.End,
            DataConstants.DateFomat,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out end))
            {
                ModelState.AddModelError(nameof(model.End),
                    $"Invalid date!Formast must be: {DataConstants.DateFomat}");
            };

            if (!ModelState.IsValid)
            {
                model.Types = await GetTypes();
                return View(model);
            }

            var entity = new Event()
            {
                CreatedOn = DateTime.Now,
                Description = model.Description,
                Name = model.Name,
                OrganaserId = GetUserId(),
                TypeId = model.TypeId,
                Start = start,
                End = end
            };

            await _data.Events.AddAsync(entity);
            await _data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var e = await _data.Events
                .FindAsync(id);
            if (e == null)
            {
                return BadRequest();
            }

            if (e.OrganaserId != GetUserId())
            {
                return Unauthorized();
            }

            var model = new EventFormViewModel()
            {
                Description = e.Description,
                Name = e.Name,
                End = e.End.ToString(DataConstants.DateFomat),
                Start = e.Start.ToString(DataConstants.DateFomat),
                TypeId = e.TypeId
            };

            model.Types = await GetTypes(); 

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EventFormViewModel model, int id)
        {
            var e = await _data.Events
                .FindAsync(id);
            if (e == null)
            {
                return BadRequest();
            }

            if (e.OrganaserId != GetUserId())
            {
                return Unauthorized();
            }

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;

            if (DateTime.TryParseExact(
            model.Start,
            DataConstants.DateFomat,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out start))
            {
                ModelState.AddModelError(nameof(model.Start),
                    $"Invalid date!Formast must be: {DataConstants.DateFomat}");
            }

            if (DateTime.TryParseExact(
            model.End,
            DataConstants.DateFomat,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out end))
            {
                ModelState.AddModelError(nameof(model.End),
                    $"Invalid date!Formast must be: {DataConstants.DateFomat}");
            }

            if (!ModelState.IsValid)
            {
                model.Types = await GetTypes();
                return View(model);
            }

            e.Start = start;
            e.End = end;
            e.Description = model.Description;
            e.Name = model.Name;
            e.TypeId = model.TypeId;

            await _data.SaveChangesAsync();

            return RedirectToAction(nameof(All));

        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await _data.Events
                .Where(e => e.Id == id)
                .AsNoTracking()
                .Select(e => new EventDetailsViewModel()
                {
                    Id = e.Id,
                    CreatedOn = e.CreatedOn.ToString(DataConstants.DateFomat),
                    Description = e.Description,
                    End = e.End.ToString(DataConstants.DateFomat),
                    Name = e.Name,
                    Organiser = e.Organaser.UserName,
                    Start = e.Start.ToString(DataConstants.DateFomat),
                    Type = e.Type.Name
                })
                .FirstOrDefaultAsync();
            if (model == null)
            {
                return BadRequest();
            }
            return View(model);
        }
        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }

        private async Task<IEnumerable<TypeViewModel>> GetTypes() 
        { 
            return await _data.Types
                .AsNoTracking()
                .Select(t => new TypeViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToListAsync();
        }

    }
}
