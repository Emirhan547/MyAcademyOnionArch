using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.FooterAddressServices;

namespace OnionApp.WebUI.ViewComponents.FooterAddressComponents
{
    public class _FooterAddressComponentPartial(IFooterAddressService _service):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerAddress = await _service.GetAllAsync();
            return View(footerAddress.Data);
        }
    }
}
