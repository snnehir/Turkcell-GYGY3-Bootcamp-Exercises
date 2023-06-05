using GardenApp.Infrastructure.Repositories.PlantRepository;
using GardenApp.Infrastructure.Repositories.PlantTypeRepository;
using GardenApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPlantService, PlantService>();
builder.Services.AddScoped<IPlantRepository, FakePlantRepository>();
builder.Services.AddScoped<IPlantTypeService, PlantTypeService>();
builder.Services.AddScoped<IPlantTypeRepository, FakePlantTypeRepository>();

builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(15);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
