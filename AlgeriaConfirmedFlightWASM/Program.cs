using AlgeriaConfirmedFlightWASM;
using AlgeriaConfirmedFlightWASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
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
