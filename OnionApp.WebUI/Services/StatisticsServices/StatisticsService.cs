using System.Net.Http.Json;
using OnionApp.WebUI.Base;

namespace OnionApp.WebUI.Services.StatisticsServices
{
    public class StatisticsService : IStatisticsService
    {
        private readonly HttpClient _client;

        public StatisticsService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<int>> GetCarCount()
        {
            var response = await _client.GetAsync("statistics/GetCarCount");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetLocationCount()
        {
            var response = await _client.GetAsync("statistics/GetLocationCount");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetAuthorCount()
        {
            var response = await _client.GetAsync("statistics/GetAuthorCount");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetBlogCount()
        {
            var response = await _client.GetAsync("statistics/GetBlogCount");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetBrandCount()
        {
            var response = await _client.GetAsync("statistics/GetBrandCount");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<decimal>> GetAvgRentPriceForDaily()
        {
            var response = await _client.GetAsync("statistics/GetAvgRentPriceForDaily");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<decimal>>();

            return result ?? new BaseResult<decimal>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<decimal>> GetAvgRentPriceForWeekly()
        {
            var response = await _client.GetAsync("statistics/GetAvgRentPriceForWeekly");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<decimal>>();

            return result ?? new BaseResult<decimal>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<decimal>> GetAvgRentPriceForMonthly()
        {
            var response = await _client.GetAsync("statistics/GetAvgRentPriceForMonthly");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<decimal>>();

            return result ?? new BaseResult<decimal>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetCarCountByTranmissionIsAuto()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByTranmissionIsAuto");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<string>> GetBrandNameByMaxCar()
        {
            var response = await _client.GetAsync("statistics/GetBrandNameByMaxCar");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();

            return result ?? new BaseResult<string>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<string>> GetBlogTitleByMaxBlogComment()
        {
            var response = await _client.GetAsync("statistics/GetBlogTitleByMaxBlogComment");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();

            return result ?? new BaseResult<string>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetCarCountByKmSmallerThen1000()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByKmSmallerThen1000");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetCarCountByFuelGasolineOrDiesel()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByFuelGasolineOrDiesel");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<int>> GetCarCountByFuelElectric()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByFuelElectric");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();

            return result ?? new BaseResult<int>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<string>> GetCarBrandAndModelByRentPriceDailyMax()
        {
            var response = await _client.GetAsync("statistics/GetCarBrandAndModelByRentPriceDailyMax");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();

            return result ?? new BaseResult<string>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<string>> GetCarBrandAndModelByRentPriceDailyMin()
        {
            var response = await _client.GetAsync("statistics/GetCarBrandAndModelByRentPriceDailyMin");

            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();

            return result ?? new BaseResult<string>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}