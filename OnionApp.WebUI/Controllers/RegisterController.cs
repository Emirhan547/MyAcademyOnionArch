using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnionApp.WebUI.Dtos.RegisterDtos;
using System.Text;

namespace OnionApp.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HttpClient _client;

        public RegisterController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        [HttpGet]
        public IActionResult CreateAppUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUser(CreateRegisterDto createRegisterDto)
        {
            var jsonData = JsonConvert.SerializeObject(createRegisterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await _client.PostAsync("https://localhost:7188/api/Registers", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

    }
}
