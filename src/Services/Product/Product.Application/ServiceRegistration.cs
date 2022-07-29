using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Application.Features.Styles.Queries;
using Product.Domain.Entities;
using System.Collections.Generic;
using System.Reflection;

namespace Product.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IRequestHandler<GetStylesListQuery, IEnumerable<Style>>, StyleQuerisHandler>();
            services.AddScoped<IRequestHandler<GetStyleByIdQuery, Style>, StyleQuerisHandler>();

            return services;
        }
    }
}