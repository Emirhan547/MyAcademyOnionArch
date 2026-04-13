using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.FooterAddressDtos;
using OnionApp.WebUI.Dtos.TestimonialDtos;

namespace OnionApp.WebUI.Services.FooterAddressServices
{
    public class FooterAddressService:IFooterAddressService
    {
        private readonly HttpClient _client;

        public FooterAddressService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultFooterAddressDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("footeraddress");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultFooterAddressDto>>>();

            return result ?? new BaseResult<List<ResultFooterAddressDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateFooterAddressDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"footeraddress/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateFooterAddressDto>>();

            return result ?? new BaseResult<UpdateFooterAddressDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateFooterAddressDto create)
        {
            var response = await _client.PostAsJsonAsync("footeraddress", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateFooterAddressDto update)
        {
            var response = await _client.PutAsJsonAsync("footeraddress", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"footeraddress/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
