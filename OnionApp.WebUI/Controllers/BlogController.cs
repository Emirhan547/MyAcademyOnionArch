using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.BlogServices;

namespace OnionApp.WebUI.Controllers
{
    public class BlogController(IBlogService _service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllBlogsWithAuthorAsync();
            return View(result.Data);
        }
        public IActionResult BlogDetail(int id)
        {
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Blog Detayı ve Yorumlar";
            ViewBag.blogid=id;
            return View();
        }
    }
}
