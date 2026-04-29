using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AuthorDtos;
using OnionApp.WebUI.Dtos.BlogDtos;

namespace OnionApp.WebUI.Services.BlogServices
{
    public class BlogService:IBlogService
    {
        private readonly HttpClient _client;

        public BlogService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultLast3BlogsWithAuthorsDto>>> GetAll3LastBlogsWithAuthorsAsync()
        {
            var response = await _client.GetAsync("blogs/GetLast3BlogsWithAuthors");
            var json = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultLast3BlogsWithAuthorsDto>>>();
            return json ?? new BaseResult<List<ResultLast3BlogsWithAuthorsDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultAllBlogsWithAuthorDto>>> GetAllBlogsWithAuthorAsync()
        {
            var response = await _client.GetAsync("blogs/GetAllBlogsWithAuthor");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultAllBlogsWithAuthorDto>>>();
            return result ?? new BaseResult<List<ResultAllBlogsWithAuthorDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultAuthorByBlogAuthorIdDto>>> GetBlogByAuthorId(int id)
        {
            var response = await _client.GetAsync("blogs/GetBlogByAuthorId?id=" + id);
            var json = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultAuthorByBlogAuthorIdDto>>>();
            return json ?? new BaseResult<List<ResultAuthorByBlogAuthorIdDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<ResultGetBlogByIdDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"blogs/GetById/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();

                return new BaseResult<ResultGetBlogByIdDto>
                {
                    Errors = new() { new Error { ErrorMessage = $"API Error: {error}" } }
                };
            }

            var json = await response.Content.ReadFromJsonAsync<BaseResult<ResultGetBlogByIdDto>>();

            return json ?? new BaseResult<ResultGetBlogByIdDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
    }

