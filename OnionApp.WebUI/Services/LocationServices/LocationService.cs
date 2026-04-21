using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.LocationDtos;

namespace OnionApp.WebUI.Services.LocationServices
{
    public class LocationService: ILocationService 
    {
        private readonly HttpClient _client;

        public LocationService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<List<ResultLocationDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("locations");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultLocationDto>>>();

            return result ?? new BaseResult<List<ResultLocationDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateLocationDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"locations/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateLocationDto>>();

            return result ?? new BaseResult<UpdateLocationDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> CreateAsync(CreateLocationDto create)
        {
            var response = await _client.PostAsJsonAsync("locations", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateLocationDto update)
        {
            var response = await _client.PutAsJsonAsync("locations", update);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"locations/{id}");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
