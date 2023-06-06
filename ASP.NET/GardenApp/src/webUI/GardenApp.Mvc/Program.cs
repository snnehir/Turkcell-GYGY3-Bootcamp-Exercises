using GardenApp.Infrastructure.Data;
using GardenApp.Infrastructure.Repositories.PlantRepository;
using GardenApp.Infrastructure.Repositories.PlantTypeRepository;
using GardenApp.Infrastructure.Repositories.UserRepository;
using GardenApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPlantService, PlantService>();
builder.Services.AddScoped<IPlantRepository, EFPlantRepository>();
builder.Services.AddScoped<IPlantTypeService, PlantTypeService>();
builder.Services.AddScoped<IPlantTypeRepository, EFPlantTypeRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, EFUserRepository>();

builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(15);
});

var connectionString = builder.Configuration.GetConnectionString("db");
// lifetime: scoped
builder.Services.AddDbContext<GardenAppDbContext>(opt =>
{
    opt.UseSqlServer(connectionString);
});
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt =>
                {
                    opt.LoginPath = "/User/Login";
                    opt.AccessDeniedPath = "/User/AccessDenied";
                    opt.ReturnUrlParameter = "redirectUrl";
                });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<GardenAppDbContext>();
context.Database.EnsureCreated();
DbSeeding.SeedDatabase(context);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
