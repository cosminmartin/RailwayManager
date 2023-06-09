﻿using Libraries.JWTTokenManager;

namespace RailwayManagerApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			services.Configure<TokenConfig>(Configuration.GetSection("TokenConfigs"));
			services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowSpecificOrigins",
                                  builder =>
                                  {
                                      builder
                                        .AllowAnyOrigin()
                                        .AllowAnyMethod()
                                        .AllowAnyHeader();
                                  });
            });
            services.RegisterModulesDependencyInjection(Configuration);
			services.RegisterJWTAuthenticationAndAuthorization(Configuration);
			services.AddEndpointsApiExplorer();
			services.RegisterSwagger(Configuration);
			services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowBlazorOrigin",
                        builder =>
                        {
                            //builder.WithOrigins("https://localhost:7000/", "https://localhost:7209/");
                            builder
                                       .AllowAnyOrigin()
                                       .AllowAnyMethod()
                                       .AllowAnyHeader();
                        }
                    );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("AllowBlazorOrigin");

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseCors("AllowSpecificOrigins");
            app.UseAuthorization();


            app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
            app.UseHsts();
        }
    }
}