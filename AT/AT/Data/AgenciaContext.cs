using AT.Data.Configurations;
using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Data
{
    public class AgenciaContext : DbContext
    {
        public AgenciaContext() { }

        public AgenciaContext(DbContextOptions<AgenciaContext> options) : base(options) { }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Destino> Destinos { get; set; }
        public virtual DbSet<PacoteTuristico> PacotesTuristicos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new DestinoConfiguration());
            modelBuilder.ApplyConfiguration(new PacoteTuristicoConfiguration());
            modelBuilder.ApplyConfiguration(new ReservaConfiguration());
        }
    }
}
