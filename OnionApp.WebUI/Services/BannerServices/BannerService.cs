using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.BannerDtos;

namespace OnionApp.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client;

        public BannerService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }
        public async Task<BaseResult<object>> CreateAsync(CreateBannerDto create)
        {
            var response = await _client.PostAsJsonAsync("banners", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"banners" + id);
            var result=await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultBannerDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("banners");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultBannerDto>>>();

            return result ?? new BaseResult<List<ResultBannerDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };

        }

        public async Task<BaseResult<UpdateBannerDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"banners" +id);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateBannerDto>>();

            return result ?? new BaseResult<UpdateBannerDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateBannerDto update)
        {
            var response = await _client.PutAsJsonAsync("banners", update);
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
                 return result ?? new BaseResult<object>
                 {
                     Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
                 };
        }
    }
}
