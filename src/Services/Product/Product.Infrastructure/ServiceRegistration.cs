using Microsoft.Extensions.DependencyInjection;
using Product.Application.Contracts.Persistence;
using Product.Infrastructure.Data;
using Product.Infrastructure.Models.Configurations;
using Product.Infrastructure.Repositories;
using System;

namespace Product.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, Action<MongoDbOptions> options)
        {
            services.Configure<MongoDbOptions>(options);

            services.AddSingleton<IProductContext, ProductContext>();
            services.AddScoped<IStyleRepository, StyleRepository>();
            services.AddScoped<ISkuRepository, SkuRepository>();

            return services;
        }
    }
}
