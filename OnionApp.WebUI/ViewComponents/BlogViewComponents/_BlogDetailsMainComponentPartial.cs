using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.BlogServices;

namespace OnionApp.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentPartial(IBlogService _service):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result == null || result.Data == null)
            {
                return Content("Blog bulunamadı");
            }

            return View(result.Data);
        }
    }
}
