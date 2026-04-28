using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.CarDescriptionDtos;
using OnionApp.WebUI.Dtos.FeatureDtos;

namespace OnionApp.WebUI.Services.CarDescriptionServices
{
    public class CarDescriptionService : ICarDescriptionService
    {
        private readonly HttpClient _client;

        public CarDescriptionService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task <BaseResult<ResultCarDescriptionByCarIdDto>> GetCarDescription(int carId)
        {
            var response = await _client.GetAsync("CarDescriptions");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<ResultCarDescriptionByCarIdDto>>();

            return result ?? new BaseResult<ResultCarDescriptionByCarIdDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
