
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using WebApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// IMPORTANTE: Cambia esta URL por la URL base de tu API
var apiBaseUrl = "https://localhost:7123";

// Configura el HttpClient para que apunte a tu API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });

// Añade los servicios de MudBlazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();