using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.CategoryServices;

namespace OnionApp.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsCategoryComponentPartial(ICategoryService _service):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoreis=await _service.GetAllAsync();
            return View(categoreis.Data);
        }
    }
}
