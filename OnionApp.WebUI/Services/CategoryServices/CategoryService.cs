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
        

        public async Task<BaseResult<List<ResultCategoryDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("categories");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCategoryDto>>>();

            return result ?? new BaseResult<List<ResultCategoryDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        
    }
}
