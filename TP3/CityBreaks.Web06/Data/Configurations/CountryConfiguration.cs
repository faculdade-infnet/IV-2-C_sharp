using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web05.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.CountryName)
                   .HasMaxLength(100)
                   .HasColumnName("Name");

            builder.HasData(
                new Country { Id = 1, CountryCode = "PT", CountryName = "Portugal" },
                new Country { Id = 2, CountryCode = "FR", CountryName = "França" },
                new Country { Id = 3, CountryCode = "BR", CountryName = "Brasil" }
            );
        }
    }
}
