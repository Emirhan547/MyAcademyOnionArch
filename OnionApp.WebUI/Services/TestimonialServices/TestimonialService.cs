using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.TestimonialDtos;

namespace OnionApp.WebUI.Services.TestimonialServices
{
    public class TestimonialService:ITestimonialService
    {
        private readonly HttpClient _client;

        public TestimonialService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultTestimonialDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("testimonials");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultTestimonialDto>>>();

            return result ?? new BaseResult<List<ResultTestimonialDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateTestimonialDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"testimonials/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateTestimonialDto>>();

            return result ?? new BaseResult<UpdateTestimonialDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateTestimonialDto create)
        {
            var response = await _client.PostAsJsonAsync("testimonials", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateTestimonialDto update)
        {
            var response = await _client.PutAsJsonAsync("testimonials", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"testimonials/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
