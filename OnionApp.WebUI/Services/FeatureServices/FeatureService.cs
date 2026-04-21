using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.FeatureDtos;

namespace OnionApp.WebUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client;

        public FeatureService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<List<ResultFeatureDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("features");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultFeatureDto>>>();

            return result ?? new BaseResult<List<ResultFeatureDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateFeatureDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"features/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateFeatureDto>>();

            return result ?? new BaseResult<UpdateFeatureDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateFeatureDto create)
        {
            var response = await _client.PostAsJsonAsync("features", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateFeatureDto update)
        {
            var response = await _client.PutAsJsonAsync("features", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"features/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
