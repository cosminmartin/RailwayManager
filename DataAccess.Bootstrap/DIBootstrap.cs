namespace DataAccess.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterDataAccessDI(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton(new DbContext(connectionString));
            services.RegisterRepositories();
        }

        private static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserReadRepository, UserReadRepository>();
            services.AddTransient<IUserWriteRepository, UserWriteRepository>();
            services.AddTransient<ITrainReadRepository, TrainReadRepository>();
            services.AddTransient<ITrainWriteRepository, TrainWriteRepository>();
        }
    }
}
