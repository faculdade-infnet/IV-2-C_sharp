using CityBreaks.Web.Models;
using CityBreaks.Web05.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Data
{
    public partial class CityBreaksContext : DbContext
    {
        public CityBreaksContext() { }

        public CityBreaksContext(DbContextOptions<CityBreaksContext> options) : base(options) { }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyConfiguration());
        }
    }
}
