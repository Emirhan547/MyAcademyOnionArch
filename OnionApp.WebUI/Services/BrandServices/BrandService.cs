using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.BrandDtos;
using OnionApp.WebUI.Dtos.FeatureDtos;

namespace OnionApp.WebUI.Services.BrandServices
{
    public class BrandService : IBrandService
    {
        private readonly HttpClient _client;

        public BrandService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<object>> CreateAsync(CreateBrandDto create)
        {
            var response = await _client.PostAsJsonAsync("brands", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"brands/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultBrandDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("features");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultBrandDto>>>();

            return result ?? new BaseResult<List<ResultBrandDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<SelectListItem>>> GetBrandSelectList()
        {
            var response = await _client.GetAsync("brands");

            var result = await response.Content
                .ReadFromJsonAsync<BaseResult<List<ResultBrandDto>>>();

            if (result == null || result.Data == null)
            {
                return new BaseResult<List<SelectListItem>>
                {
                    Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
                };
            }

            return new BaseResult<List<SelectListItem>>
            {
                Data = result.Data.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList()
            };
        }

        public async Task<BaseResult<UpdateBrandDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"brands/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateBrandDto>>();

            return result ?? new BaseResult<UpdateBrandDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateBrandDto update)
        {
            var response = await _client.PutAsJsonAsync("brands", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
