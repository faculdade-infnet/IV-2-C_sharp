using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CityBreaks.Web.Data
{
    public partial class CityBreaksContext : DbContext
    {
        public CityBreaksContext()
        {
            
        }

        public CityBreaksContext(DbContextOptions<CityBreaksContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
    }
}
