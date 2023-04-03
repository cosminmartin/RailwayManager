using Libraries.Infrastructure.Configurations;
using Microsoft.OpenApi.Models;

namespace RailwayManagerApi.Extensions
{
    public static class IServiceCollectionExtensions
    {
        internal static void RegisterModulesDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlConnectionString =
                configuration
                    .GetSection("ConnectionStrings")
                    .Get<ConnectionStringConfigs>().SqlConnection;

            services.RegisterDataAccessDI(sqlConnectionString);
            services.RegisterDomainDI();
        }

        internal static void RegisterSwagger(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1",
                    new() { Title = "RailwayManager API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Insert authentification token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{}
                }
            });
            });
        }
    }
}
