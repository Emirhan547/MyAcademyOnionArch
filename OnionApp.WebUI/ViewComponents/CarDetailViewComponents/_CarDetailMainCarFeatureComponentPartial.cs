using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.CarServices;

namespace OnionApp.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailMainCarFeatureComponentPartial(ICarService _service):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _service.GetCarWithBrands();
            return View(result);
        }
    }
}
