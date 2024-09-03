using ForumApp24.Core.Contracts;
using ForumApp24.Core.Model;
using ForumApp24.Core.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp24.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<PostModel> model = await _postService.GetAllPostsAsync();
            return View(model);
        }

        public IActionResult Add()
        {
            var model = new PostModel();
            return View(model);
        }

        public async  Task<IActionResult> Add(PostModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await _postService.AddAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            PostModel? model = await _postService.GetByIdAsync(id);

            if (model == null)
            {
                ModelState.AddModelError("All", "Invalid post!");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await _postService.EditAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _postService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
