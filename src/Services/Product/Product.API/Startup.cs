using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Product.API.Queries;
using Product.API.Resolvers;
using Product.API.Types;
using Product.Application;
using Product.Infrastructure;

namespace Product.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            services.AddApplicationServices(Configuration);
            services.AddInfrastructureServices(Configuration);

            services.AddGraphQLServer()
                .AddType<StyleType>()
                .AddType<OptionType>()
                .AddResolver<SkuResolver>()
                .AddQueryType(q => q.Name("Query"))
                    .AddType<StyleQueryType>()
                .AddInMemorySubscriptions();

            services.AddHealthChecks();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL("/api/graphql");
            });
        }
    }
}
