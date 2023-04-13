namespace Domain.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterDomainDI(this IServiceCollection services)
        {
            services.RegisterCommandContexts();
            services.RegisterValidators();
            services.RegisterQueriesContexts();
            services.AddTransient<IUserCommands, UserCommands>();
            services.AddTransient<IUserQueries, UserQueries>();
            services.RegisterPasswordManagerDI();
        }
        public static void RegisterCommandContexts(this IServiceCollection services)
        {
            services.AddTransient<ICreateUserCommandContext, CreateUserCommandContext>();
        }
        public static void RegisterQueriesContexts(this IServiceCollection services)
        {
            services.AddTransient<IGetUserByIdQueryContext, GetUserByIdQueryContext>();
        }

        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateUserCommand>, CreateUserCommandValidator>();
            services.AddScoped<IValidator<GetUserByIdQuery>, GetUserByIdQueryValidator>();
        }
    }
}
