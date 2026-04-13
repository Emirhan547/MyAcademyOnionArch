using Microsoft.AspNetCore.Mvc;

namespace OnionApp.WebUI.Controller
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
