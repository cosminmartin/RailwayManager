using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RailwayManagerBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<Utilities.ILocalStorage, Utilities.LocalStorage>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7209/") });

await builder.Build().RunAsync();
