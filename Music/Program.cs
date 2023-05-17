using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Music.Models;

namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            //   app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            DBConfiguration.ConnectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}