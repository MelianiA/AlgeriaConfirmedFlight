using AlgeriaConfirmedFlightWASM;
using AlgeriaConfirmedFlightWASM.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// add after builder initialization:
builder.Services.AddBlazoredLocalStorage();   // local storage
builder.Services.AddBlazoredLocalStorage(config => config.JsonSerializerOptions.WriteIndented = true);  // local storage

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
 


builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(@"http://www.iasoft.fr/api/")
    });
builder.Services.AddScoped<IVolConfirmeService, VolConfirmeService>();
 

await builder.Build().RunAsync();
