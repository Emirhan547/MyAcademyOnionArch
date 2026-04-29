using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.FooterAddressDtos;

namespace UdemyCarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _FooterUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7069/api/FooterAddresses");

            if (!responseMessage.IsSuccessStatusCode)
                return View(new List<ResultFooterAddressDto>());

            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<BaseResult<List<ResultFooterAddressDto>>>(jsonData);

            var data = result?.Data ?? new List<ResultFooterAddressDto>();

            return View(data);
        }
    }
}
