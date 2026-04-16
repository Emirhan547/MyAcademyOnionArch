using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.BannerDtos;
using OnionApp.WebUI.Dtos.TagCloudDtos;

namespace OnionApp.WebUI.Services.TagCloudServices
{
    public class TagCloudService : ITagCloudService
    {
        private readonly HttpClient _client;

        public TagCloudService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<object>> CreateAsync(CreateTagCloudDto create)
        {
            var response = await _client.PostAsJsonAsync("tagclouds", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"tagclouds" + id);
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultTagCloudDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("tagclouds");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultTagCloudDto>>>();

            return result ?? new BaseResult<List<ResultTagCloudDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };

        }

        public async Task<BaseResult<ResultGetByBlogIdTagCloudDto>> GetTagCloudById(int id)
        {
            var response = await _client.GetAsync($"GetTagCloudById?id=" + id);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<ResultGetByBlogIdTagCloudDto>>();

            return result ?? new BaseResult<ResultGetByBlogIdTagCloudDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateTagCloudDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"tagclouds" + id);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateTagCloudDto>>();

            return result ?? new BaseResult<UpdateTagCloudDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateTagCloudDto update)
        {
            var response = await _client.PutAsJsonAsync("tagclouds", update);
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
