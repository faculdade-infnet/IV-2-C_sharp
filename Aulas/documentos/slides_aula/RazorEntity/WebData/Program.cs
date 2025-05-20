using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<LibraryContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnection"));
                
            });

            //builder.Services.AddDbContext<LibraryContext>(options =>
            //{
            //    options.UseSqlServer(
            //        builder.Configuration.GetConnectionString("LibraryConnection"),
            //        x => x.MigrationsHistoryTable("HistoricoMigrations", "dbo")
            //        );
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
