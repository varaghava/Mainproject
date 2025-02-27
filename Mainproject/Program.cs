using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mainproject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MainprojectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainprojectContext") ?? throw new InvalidOperationException("Connection string 'MainprojectContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Doctors}/{action=Index}/{id?}");



app.Run();
