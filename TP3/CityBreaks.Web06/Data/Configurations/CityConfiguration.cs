using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web05.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {            
            builder.Property(c => c.Name)                   
                   .HasColumnName("Name");

            builder.HasData(
                new City { Id = 1, Name = "Lisboa", CountryId = 1 },
                new City { Id = 2, Name = "Porto", CountryId = 1 },
                new City { Id = 3, Name = "Paris", CountryId = 2 },
                new City { Id = 4, Name = "Rio de Janeiro", CountryId = 3 },
                new City { Id = 5, Name = "São Paulo", CountryId = 3 }
            );
        }
    }
}
