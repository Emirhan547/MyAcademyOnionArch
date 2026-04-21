using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionApp.Application.Contracts;
using OnionApp.Persistence.Concrete;
using OnionApp.Persistence.Context;

namespace OnionApp.Persistence.Extensions
{
    public static class PersistenceRegistrations
    {

        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AppDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                options.UseSqlServer(connectionString);
            });

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICarPricingRepository, CarPricingRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IStatisticsRepository, StatisticsRepository>();
            services.AddScoped<ITagCloudRepository, TagCloudRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;

        }

    }
}