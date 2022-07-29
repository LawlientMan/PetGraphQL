using Microsoft.Extensions.DependencyInjection;
using Product.Application.Repositories;
using Product.Infrastructure.Configurations;
using Product.Infrastructure.Data;
using Product.Infrastructure.Repositories;

namespace Product.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, MongoDbConfiguration configuration)
        {
            services.AddSingleton(configuration);

            services.AddSingleton<IProductContext, ProductContext>();
            services.AddScoped<IStyleRepository, StyleRepository>();
            services.AddScoped<ISkuRepository, SkuRepository>();

            return services;
        }
    }
}
