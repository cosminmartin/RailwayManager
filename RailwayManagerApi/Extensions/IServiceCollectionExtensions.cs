using Libraries.JWTTokenManager;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

		internal static void RegisterJWTAuthenticationAndAuthorization(this IServiceCollection services,
		IConfiguration configuration)
		{
			var tokenConfigs = configuration.GetSection("TokenConfigs").Get<TokenConfig>();

			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(o =>
			{
				o.TokenValidationParameters = new TokenValidationParameters
				{
					ValidIssuer = tokenConfigs.Issuer,
					ValidAudience = tokenConfigs.Audience,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfigs.SecretKey)),
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ClockSkew = TimeSpan.Zero
				};
			});

			services.AddAuthorization();
		}

		internal static void RegisterSwagger
			(this IServiceCollection services,
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
