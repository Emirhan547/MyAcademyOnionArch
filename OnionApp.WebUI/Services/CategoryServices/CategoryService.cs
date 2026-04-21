using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.CategoryDtos;

namespace OnionApp.WebUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<object>> CreateAsync(CreateCategoryDto create)
        {
            var response = await _client.PostAsJsonAsync("categories", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"categories/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultCategoryDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("categories");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCategoryDto>>>();

            return result ?? new BaseResult<List<ResultCategoryDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateCategoryDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"categories/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateCategoryDto>>();

            return result ?? new BaseResult<UpdateCategoryDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateCategoryDto update)
        {
            var response = await _client.PutAsJsonAsync("categories", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
