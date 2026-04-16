using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.BlogDtos;
using OnionApp.WebUI.Dtos.CarPricingDtos;

namespace OnionApp.WebUI.Services.CarPricingServices
{
    public class CarPricingService : ICarPricingService
    {

        private readonly HttpClient _client;

        public CarPricingService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultCarPricingWithCarDto>>> GetCarPricingWithCar()
        {
            var response = await _client.GetAsync("carpricings");
            var result = await response.Content.ReadFromJsonAsync <BaseResult<List<ResultCarPricingWithCarDto>>>();
            return result ?? new BaseResult<List<ResultCarPricingWithCarDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
