namespace RailwayManagerApi;

public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateWebHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webHost =>
        {
            webHost
                .ConfigureKestrel(c => c.AddServerHeader = false)
                .UseStartup<Startup>();
        });
}