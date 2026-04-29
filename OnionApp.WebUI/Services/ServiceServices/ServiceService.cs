using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.ServiceDtos;
using OnionApp.WebUI.Dtos.TestimonialDtos;
using OnionApp.WebUI.Services.ServiceServices;

namespace OnionApp.WebUI.Services.FeatureServices
{
    public class ServiceService : IServiceService
    {
        private readonly HttpClient _client;

        public ServiceService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<List<ResultServiceDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("services");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultServiceDto>>>();

            return result ?? new BaseResult<List<ResultServiceDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateServiceDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"services/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateServiceDto>>();

            return result ?? new BaseResult<UpdateServiceDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateServiceDto create)
        {
            var response = await _client.PostAsJsonAsync("services", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateServiceDto update)
        {
            var response = await _client.PutAsJsonAsync("services", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"services/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
