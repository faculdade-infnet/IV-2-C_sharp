using CityBreaks.Web.Data;
using CityBreaks.Web06.Services;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            
            builder.Services.AddDbContext<CityBreaksContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("CityBreakConnection"));
            });

            // Inje��o do servi�o
            builder.Services.AddScoped<ICityService, CityService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
