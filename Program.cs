using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using moshaver.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //string connectionString = builder.Configuration.GetConnectionString("moshaverandb"); IServiceCollection serviceCollection = builder.Services.AddDbContext<MoshaverDbContext>(x =>
        //{
        //    //object value = x.UseSqlServer(connectionString);
        //});
       // Add services to the container.
        builder.Services.AddControllersWithViews();
   builder.Services.AddDbContext<MoshaverDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("moshaverDB")), ServiceLifetime.Singleton);
       
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
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}