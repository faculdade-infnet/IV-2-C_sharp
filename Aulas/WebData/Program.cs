using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);            
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<LibraryContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnection"));

            });

            // Nome da tabela histórico de migrações - MIGRATIONS
            //builder.Services.AddDbContext<LibraryContext>(options =>
            //{
            //    options.UseSqlServer(
            //        builder.Configuration.GetConnectionString("LibraryConnection"), 
            //        x=> x.MigrationsHistoryTable("HistoricoMigrations", "dbo")
            //    );
            //});

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
