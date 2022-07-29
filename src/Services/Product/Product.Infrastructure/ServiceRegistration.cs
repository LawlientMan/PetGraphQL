using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Application.Repositories;
using Product.Infrastructure.Data;
using Product.Infrastructure.Models.Configurations;
using Product.Infrastructure.Repositories;

namespace Product.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbConfiguration>(configuration.GetSection(nameof(MongoDbConfiguration)));

            services.AddSingleton<IProductContext, ProductContext>();
            services.AddScoped<IStyleRepository, StyleRepository>();
            services.AddScoped<ISkuRepository, SkuRepository>();

            return services;
        }
    }
}
