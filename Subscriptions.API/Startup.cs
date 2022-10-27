using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Subscriptions.Infrastructure;

namespace Subscriptions.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddInfrastructure(this.Configuration);
            SwaggerDoc(services);
        }

        private static void SwaggerDoc(IServiceCollection services) =>
            services.AddSwaggerGen(config =>
            {
                var openApiInfo = new OpenApiInfo
                {
                    Title = "Subscriptions Api",
                    Description = "Customer can subscribe to a product, N-Tier without CQRS Event Driven",
                    Version = "Version 1.0"
                };

                var openApiContact = new OpenApiContact
                {
                    Email = "fadidib23@hotmail.com",
                    Name = "fadi dib",
                    Url = new Uri("https://www.linkedin.com/in/fadi-dib-827365226/")
                };

                config.SwaggerDoc(
                    name: "v1",
                    info: openApiInfo);
            });

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(config =>
                    config.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "Subscriptions.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        }
    }
}
