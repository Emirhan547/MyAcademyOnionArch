using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.AboutServices;

namespace OnionApp.WebUI.Controllers
{
    public class AboutController(IAboutService _service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var abouts=await _service.GetAllAsync();
            return View(abouts.Data);
        }
    }
}
