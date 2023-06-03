var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
var message = app.Configuration.GetSection("Message")["greeting"];

// app.MapGet("/", () => message);

// app.UseMvcWithDefaultRoute();

app.UseRouting();

// app.UseWelcomePage(); Middleware örnek 

// app.UseEndpoints(e => e.MapControllerRoute("default", "{controler=Home}/{action=Index}/{id?}"));

app.UseStaticFiles(); // wwwroot, bootstrap
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
