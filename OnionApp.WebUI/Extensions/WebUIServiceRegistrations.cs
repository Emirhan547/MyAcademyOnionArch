using OnionApp.WebUI.Services.AboutServices;

namespace OnionApp.WebUI.Extensions
{
    public static class WebUIServiceRegistrations
    {
        public static void AddServiceExt(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutService>();
        }
    }
}
