using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Orquestador_Telecom.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Orquestador Telecom",
                    Version = "v3",
                    Description = "Sistema que comunica a todos los microservicios",
                    Contact = new OpenApiContact
                    {
                        Name = "CDA",
                        Url = new Uri("http://www.cdainfo.com/es/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                    },
                });
            });
            return services;
        }

        public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger().UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Orquestador Telecom");
                options.DocumentTitle = "Orquestador Telecom";
            });
            return app;
        }
    }
}
