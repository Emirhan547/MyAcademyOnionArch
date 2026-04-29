using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.CarFeatureDtos;
using OnionApp.WebUI.Dtos.FeatureDtos;

namespace OnionApp.WebUI.Services.CarFeatureServices
{
    public class CarFeatureService : ICarFeatureService
    {
        private readonly HttpClient _client;

        public CarFeatureService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task ChangeCarFeatureAvailableToFalse(int id)
        {
            await _client.PutAsync($"CarFeatureChangeAvailableToFalse/{id}", null);
        }

        public async Task ChangeCarFeatureAvailableToTrue(int id)
        {
            await _client.PutAsync($"CarFeatureChangeAvailableToTrue/{id}", null);
        }

        public async Task<BaseResult<List<ResultFeatureDto>>> CreateFeatureByCarId()
        {
            var response = await _client.GetAsync("CarPricings");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultFeatureDto>>>();

            return result ?? new BaseResult<List<ResultFeatureDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultCarFeatureByCarIdDto>>> GetCarFeaturesByCarId(int carId)
        {
            var response = await _client.GetAsync($"carsFeatures/GetCarFeaturesByCarId/{carId}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCarFeatureByCarIdDto>>>();

            return result ?? new BaseResult<List<ResultCarFeatureByCarIdDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
