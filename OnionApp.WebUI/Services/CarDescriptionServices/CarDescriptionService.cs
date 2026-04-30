using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.CarDescriptionDtos;
using OnionApp.WebUI.Dtos.FeatureDtos;
using System.Text.Json;

namespace OnionApp.WebUI.Services.CarDescriptionServices
{
    public class CarDescriptionService : ICarDescriptionService
    {
        private readonly HttpClient _client;

        public CarDescriptionService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<ResultCarDescriptionByCarIdDto>> GetCarDescription(int carId)
        {
            var response = await _client.GetAsync($"CarDescriptions/{carId}");

            if (!response.IsSuccessStatusCode)
            {
                return new BaseResult<ResultCarDescriptionByCarIdDto>
                {
                    Errors = new() { new Error { ErrorMessage = "API hatası" } }
                };
            }

            var content = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(content))
            {
                return new BaseResult<ResultCarDescriptionByCarIdDto>
                {
                    Errors = new() { new Error { ErrorMessage = "Boş response geldi" } }
                };
            }

            var result = JsonSerializer.Deserialize<BaseResult<ResultCarDescriptionByCarIdDto>>(content);

            return result ?? new BaseResult<ResultCarDescriptionByCarIdDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
