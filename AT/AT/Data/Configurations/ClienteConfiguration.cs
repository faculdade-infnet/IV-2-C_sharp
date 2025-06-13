using AT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                new Cliente { Id = 1, Nome = "Alice Fernandes", Email = "alice.fernandes@email.com" },
                new Cliente { Id = 2, Nome = "Bruno Martins", Email = "bruno.martins@email.com" },
                new Cliente { Id = 3, Nome = "Carla Ribeiro", Email = "carla.ribeiro@email.com" },
                new Cliente { Id = 4, Nome = "Diego Souza", Email = "diego.souza@email.com" },
                new Cliente { Id = 5, Nome = "Elaine Costa", Email = "elaine.costa@email.com" }
            );
        }
    }
}