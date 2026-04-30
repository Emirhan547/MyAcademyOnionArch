using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.BannerDtos;
using OnionApp.WebUI.Dtos.CommentDtos;

namespace OnionApp.WebUI.Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient _client;

        public CommentService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<object>> CreateAsync(CreateCommentDto create)
        {
            var response = await _client.PostAsJsonAsync("comments", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"comments/{id}");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultCommentDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("comments");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCommentDto>>>();

            return result ?? new BaseResult<List<ResultCommentDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };

        }

        public async Task<BaseResult<UpdateCommentDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"comments/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateCommentDto>>();

            return result ?? new BaseResult<UpdateCommentDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultGetCommentWithBlogDto>>> GetCommentsByBlogId(int id)
        {
            var response = await _client.GetAsync($"comments/GetCommentWithBlog/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultGetCommentWithBlogDto>>>();

            return result ?? new BaseResult<List<ResultGetCommentWithBlogDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<ResultCommentCountDto>> GetCountCommentByBlogAsync(int id)
        {
            var response = await _client.GetAsync($"comments/GetCommentCount/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return new BaseResult<ResultCommentCountDto>
                {
                    Errors = new() { new Error { ErrorMessage = "API hatası" } }
                };
            }

            var result = await response.Content.ReadFromJsonAsync<BaseResult<ResultCommentCountDto>>();

            return result ?? new BaseResult<ResultCommentCountDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateCommentDto update)
        {
            var response = await _client.PutAsJsonAsync("comments", update);
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        
    }
}
