using DataAccess.Contracts.Repositories.Users;
using DataAccess.Implementations.Users;

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
        }
    }
}
