using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.ReviewDtos;

namespace OnionApp.WebUI.Services.ReviewServices
{
    public class ReviewService:IReviewService
    {
        private readonly HttpClient _client;

        public ReviewService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultReviewByCarIdDto>>> GetReviewsByCarId(int carId)
        {
            var response = await _client.GetAsync($"reviews/{carId}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultReviewByCarIdDto>>>();

            return result ?? new BaseResult<List<ResultReviewByCarIdDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
