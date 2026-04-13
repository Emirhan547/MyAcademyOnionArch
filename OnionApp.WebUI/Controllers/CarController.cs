using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.CarServices;

namespace OnionApp.WebUI.Controllers
{
    public class CarController (ICarService _service): Controller
    {
        public async Task<IActionResult> Index()
        {
            var cars=await _service.GetCarWithBrands();
            return View(cars.Data);
        }
    }
}
