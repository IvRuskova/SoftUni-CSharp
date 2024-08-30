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
            return View();
        }
    }
}
