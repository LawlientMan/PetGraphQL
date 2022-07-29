using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Product.API.Configurations;
using Product.Infrastructure;

namespace Product.API
{
    public class Startup
    {
        private readonly ApiConfiguration _apiConfiguration;
        //public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this._apiConfiguration = configuration.Get<ApiConfiguration>();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddApplicationServices();
            services.AddInfrastructureServices(_apiConfiguration.MongoDbConfiguration);
            services.AddGraphQLServer().AddQueryType<Query>();
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
