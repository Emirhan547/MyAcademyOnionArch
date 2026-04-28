using Microsoft.AspNetCore.Mvc;

namespace OnionApp.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailDescriptionComponentPartial:ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
