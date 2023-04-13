namespace Libraries.PasswordManager.Extensions
{
    public static class DIBootstrap
    {
        public static void RegisterPasswordManagerDI(this IServiceCollection services)
        {
            services.AddTransient<IPasswordManager, Managers.Password.PasswordManager>();
            services.AddTransient<ISaltManager, SaltManager>();
        }
    }
}
