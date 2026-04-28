using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Dtos.CommentDtos;
using OnionApp.WebUI.Services.BlogServices;
using OnionApp.WebUI.Services.CommentServices;

namespace OnionApp.WebUI.Controllers
{
    public class BlogController(IBlogService _service,ICommentService _commentService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllBlogsWithAuthorAsync();
            return View(result.Data);
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Blog Detayı ve Yorumlar";
            ViewBag.blogid=id;
            var result = await _commentService.GetCountCommentByBlogAsync(id);
            return View(result.Data);
        }
        public PartialViewResult AddComment(int id)
        {
            ViewBag.blogid = id;

            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto create)
        {
            await _commentService.CreateAsync(create);
            return RedirectToAction("Index","Default");
        }
    }
}
