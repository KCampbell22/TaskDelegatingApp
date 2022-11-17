using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using TaskDelegatingApp.Data;
using TaskDelegatingApp.Models;
using TaskDelegatingApp.Data;




var builder = WebApplication.CreateBuilder(args);

if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
{
    builder.Services.AddDbContext<TaskDelegatingAppContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("TasdDelegatingAppProduction")));
}
else
{
    builder.Services.AddDbContext<TaskDelegatingAppContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("TaskDelegatingAppContext") ?? throw new InvalidOperationException("Connection string 'TaskDelegatingAppContext' not found.")));
}
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
    pattern: "{controller=Home}/{action=Index}/{ID?}");

app.Run();
