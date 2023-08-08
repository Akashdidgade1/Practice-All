using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LogInPage.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DBLogInPageContextConnection") ?? throw new InvalidOperationException("Connection string 'DBLogInPageContextConnection' not found.");

builder.Services.AddDbContext<DBLogInPageContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<LogUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DBLogInPageContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();
app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
  
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
