using Microsoft.AspNetCore.Mvc;

namespace OnionApp.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
