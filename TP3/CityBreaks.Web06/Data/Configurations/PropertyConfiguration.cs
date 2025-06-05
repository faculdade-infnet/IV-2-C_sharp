using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web05.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(150)
                   .HasColumnName("Name");

            builder.HasData(
                new Property { Id = 1, Name = "Casa no Centro de Lisboa", PricePerNight = 120.00m, CityId = 1 },
                new Property { Id = 2, Name = "Apartamento no Porto", PricePerNight = 90.00m, CityId = 2 },
                new Property { Id = 3, Name = "Apartamento em Paris", PricePerNight = 200.00m, CityId = 3 },
                new Property { Id = 4, Name = "Cobertura no Rio", PricePerNight = 150.00m, CityId = 4 },
                new Property { Id = 5, Name = "Flat em São Paulo", PricePerNight = 100.00m, CityId = 5 }
            );
        }
    }
}
