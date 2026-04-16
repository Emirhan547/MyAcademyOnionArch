using OnionApp.WebUI.Services.AboutServices;
using OnionApp.WebUI.Services.BannerServices;
using OnionApp.WebUI.Services.BlogServices;
using OnionApp.WebUI.Services.CarPricingServices;
using OnionApp.WebUI.Services.CarServices;
using OnionApp.WebUI.Services.CategoryServices;
using OnionApp.WebUI.Services.ContactServices;
using OnionApp.WebUI.Services.FeatureServices;
using OnionApp.WebUI.Services.FooterAddressServices;
using OnionApp.WebUI.Services.ServiceServices;
using OnionApp.WebUI.Services.TagCloudServices;
using OnionApp.WebUI.Services.TestimonialServices;

namespace OnionApp.WebUI.Extensions
{
    public static class WebUIServiceRegistrations
    {
        public static void AddServiceExt(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<ICarPricingService, CarPricingService>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IFooterAddressService, FooterAddressService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<ITagCloudService, TagCloudService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
        }
    }
}
