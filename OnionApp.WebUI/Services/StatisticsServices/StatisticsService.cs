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

        public async Task<int> GetCarCount()
        {
            var response = await _client.GetAsync("statistics/GetCarCount");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetLocationCount()
        {
            var response = await _client.GetAsync("statistics/GetLocationCount");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetAuthorCount()
        {
            var response = await _client.GetAsync("statistics/GetAuthorCount");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetBlogCount()
        {
            var response = await _client.GetAsync("statistics/GetBlogCount");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetBrandCount()
        {
            var response = await _client.GetAsync("statistics/GetBrandCount");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<decimal> GetAvgRentPriceForDaily()
        {
            var response = await _client.GetAsync("statistics/GetAvgRentPriceForDaily");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<decimal>>();
            return result?.Data ?? 0;
        }

        public async Task<decimal> GetAvgRentPriceForWeekly()
        {
            var response = await _client.GetAsync("statistics/GetAvgRentPriceForWeekly");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<decimal>>();
            return result?.Data ?? 0;
        }

        public async Task<decimal> GetAvgRentPriceForMonthly()
        {
            var response = await _client.GetAsync("statistics/GetAvgRentPriceForMonthly");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<decimal>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetCarCountByTranmissionIsAuto()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByTranmissionIsAuto");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<string> GetBrandNameByMaxCar()
        {
            var response = await _client.GetAsync("statistics/GetBrandNameByMaxCar");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();
            return result?.Data ?? string.Empty;
        }

        public async Task<string> GetBlogTitleByMaxBlogComment()
        {
            var response = await _client.GetAsync("statistics/GetBlogTitleByMaxBlogComment");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();
            return result?.Data ?? string.Empty;
        }

        public async Task<int> GetCarCountByKmSmallerThen1000()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByKmSmallerThen1000");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetCarCountByFuelGasolineOrDiesel()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByFuelGasolineOrDiesel");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<int> GetCarCountByFuelElectric()
        {
            var response = await _client.GetAsync("statistics/GetCarCountByFuelElectric");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<int>>();
            return result?.Data ?? 0;
        }

        public async Task<string> GetCarBrandAndModelByRentPriceDailyMax()
        {
            var response = await _client.GetAsync("statistics/GetCarBrandAndModelByRentPriceDailyMax");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();
            return result?.Data ?? string.Empty;
        }

        public async Task<string> GetCarBrandAndModelByRentPriceDailyMin()
        {
            var response = await _client.GetAsync("statistics/GetCarBrandAndModelByRentPriceDailyMin");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<string>>();
            return result?.Data ?? string.Empty;
        }
    }
}