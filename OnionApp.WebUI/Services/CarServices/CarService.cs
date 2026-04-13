using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.CarDtos;

namespace OnionApp.WebUI.Services.CarServices
{
    public class CarService:ICarService
    {
        private readonly HttpClient _client;

        public CarService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultCarWithBrandsDto>>> GetCarWithBrands()
        {
            var response = await _client.GetAsync("GetCarWithBrand");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCarWithBrandsDto>>>();

            return result ?? new BaseResult<List<ResultCarWithBrandsDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultLast5CarsWithBrandsDto>>> GetLas5CarWithBrands()
        {
            var response = await _client.GetAsync("GetLast5CarsWithBrand");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultLast5CarsWithBrandsDto>>>();

            return result ?? new BaseResult<List<ResultLast5CarsWithBrandsDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
