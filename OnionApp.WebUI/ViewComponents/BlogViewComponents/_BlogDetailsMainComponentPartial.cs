using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Services.BlogServices;

namespace OnionApp.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentPartial(IBlogService _service):ViewComponent
    {
        public async Task<IViewComponentResult> Invoke(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return View(result.Data);
        }
    }
}
