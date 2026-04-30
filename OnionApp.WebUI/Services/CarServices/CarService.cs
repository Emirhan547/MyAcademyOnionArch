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
            var response = await _client.GetAsync("cars/GetCarWithBrand");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCarWithBrandsDto>>>();

            return result ?? new BaseResult<List<ResultCarWithBrandsDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultLast5CarsWithBrandsDto>>> GetLast5CarWithBrands()
        {
            var response = await _client.GetAsync("cars/GetLast5CarsWithBrand");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultLast5CarsWithBrandsDto>>>();

            return result ?? new BaseResult<List<ResultLast5CarsWithBrandsDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
        public async Task<BaseResult<List<ResultCarDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("cars");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultCarDto>>>();

            return result ?? new BaseResult<List<ResultCarDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateCarDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"cars/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateCarDto>>();

            return result ?? new BaseResult<UpdateCarDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateCarDto create)
        {
            var response = await _client.PostAsJsonAsync("cars", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateCarDto update)
        {
            var response = await _client.PutAsJsonAsync("cars", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"cars/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<ResultCarWithBrandsDto>> GetCarWithBrandByIdAsync(int id)
        {
            var response = await _client.GetAsync($"cars/GetCarWithBrandById/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<ResultCarWithBrandsDto>>();

            return result ?? new BaseResult<ResultCarWithBrandsDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

    }
}
