using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using ProniaBeta;
using ProniaBeta.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>((options) => { options.UseSqlServer(builder.Configuration.GetConnectionString("Default")); });
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"
    );

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
