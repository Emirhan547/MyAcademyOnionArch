using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnionApp.WebUI.Dtos.RentACarDtos;
using OnionApp.WebUI.Services.RentACarServices;
using System.Net.Http;
using System.Text;


namespace UdemyCarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IRentACarService _rentACarService;

        public RentACarListController(IRentACarService rentACarService)
        {
            _rentACarService = rentACarService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var locationID = TempData["locationID"];

            if (locationID == null)
                return View(new List<FilterRentACarDto>());

            id = int.Parse(locationID.ToString());

            ViewBag.locationID = locationID;

            var values = await _rentACarService.GetAvailableCarsAsync(id);

            return View(values);
        }
    }
}

