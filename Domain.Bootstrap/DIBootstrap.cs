namespace Domain.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterDomainDI(this IServiceCollection services)
        {
            services.RegisterValidators();
            services.RegisterQueriesContexts();
            services.AddTransient<IUserQueries, UserQueries>();
        }

        public static void RegisterQueriesContexts(this IServiceCollection services)
        {
            services.AddTransient<IGetUserByIdQueryContext, GetUserByIdQueryContext>();
        }

        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<GetUserByIdQuery>, GetUserByIdQueryValidator>();
        }
    }
}
