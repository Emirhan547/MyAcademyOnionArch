using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.AuthorDtos;

namespace OnionApp.WebUI.Services.AuthorServices
{
    public class AuthorService : IAuthorService
    {
        private readonly HttpClient _client;

        public AuthorService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<List<ResultAuthorDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("authors");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultAuthorDto>>>();

            return result ?? new BaseResult<List<ResultAuthorDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateAuthorDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"authors/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateAuthorDto>>();

            return result ?? new BaseResult<UpdateAuthorDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateAuthorDto create)
        {
            var response = await _client.PostAsJsonAsync("authors", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateAuthorDto update)
        {
            var response = await _client.PutAsJsonAsync("authors", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"authors/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
