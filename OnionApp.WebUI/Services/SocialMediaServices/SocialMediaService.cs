using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.SocialMediaDtos;

namespace OnionApp.WebUI.Services.SocialMediaServices
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly HttpClient _client;

        public SocialMediaService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<List<ResultSocialMediaDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("socialmedias");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultSocialMediaDto>>>();

            return result ?? new BaseResult<List<ResultSocialMediaDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateSocialMediaDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"socialmedias/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateSocialMediaDto>>();

            return result ?? new BaseResult<UpdateSocialMediaDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateSocialMediaDto create)
        {
            var response = await _client.PostAsJsonAsync("socialmedias", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateSocialMediaDto update)
        {
            var response = await _client.PutAsJsonAsync("socialmedias", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"socialmedias/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
