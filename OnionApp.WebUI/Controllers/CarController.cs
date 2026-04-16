using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.CarPricingServices;

namespace OnionApp.WebUI.Controllers
{
    public class CarController (ICarPricingService _service): Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlarımız";
            ViewBag.v2 = "Araçlarınızı Seçiniz";
            var cars=await _service.GetCarPricingWithCar();
            return View(cars.Data);
        }
    }
}
