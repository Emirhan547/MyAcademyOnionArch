using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using OnionApp.WebUI.Dtos.LocationDtos;
using OnionApp.WebUI.Dtos.ReservationDtos;
using OnionApp.WebUI.Services.LocationServices;
using OnionApp.WebUI.Services.ReservationServices;
using System.Text;

namespace OnionApp.WebUI.Controllers
{
    public class ReservationController(ILocationService _locationService,IReservationService _reservationService) : Controller
    {
        
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.v1 = "Araç Kiralama";
            ViewBag.v2 = "Araç Rezervasyon Formu";
            ViewBag.v3 = id;

            var result = await _locationService.GetAllAsync();

            List<SelectListItem> values2 = new();

            if (result.IsSuccessful && result.Data != null)
            {
                values2 = result.Data.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
            }

            ViewBag.v = values2;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateReservationDto dto)
        {
            var success = await _reservationService.CreateAsync(dto);

            if (success)
                return RedirectToAction("Index", "Default");

            return View(dto);
        }

    }
}
