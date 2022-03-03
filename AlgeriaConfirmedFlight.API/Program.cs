using AlgeriaConfirmedFlight.API.Model;
using AlgeriaConfirmedFlight.API.Repository;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins(@"https://meliania.github.io/AlgeriaConfirmedFlight/",
                                              @"https://www.iasoft.fr/api/").AllowAnyHeader()
                                                  .AllowAnyMethod();
                      });
});


//Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IVolConfirmeRepository, VolConfirmeRepository>();
builder.Services.AddMvc();

builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseAuthorization();
app.MapControllers();

app.Run();
