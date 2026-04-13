using System.Net.Http.Json;
using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;

namespace OnionApp.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultAboutDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("abouts");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultAboutDto>>>();

            return result ?? new BaseResult<List<ResultAboutDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateAboutDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"abouts/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateAboutDto>>();

            return result ?? new BaseResult<UpdateAboutDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateAboutDto create)
        {
            var response = await _client.PostAsJsonAsync("abouts", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateAboutDto update)
        {
            var response = await _client.PutAsJsonAsync("abouts", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"abouts/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}