
using Microsoft.EntityFrameworkCore;

namespace EFW_Demoo2.Contexts
{
    public class EmloyeeDbContext : DbContext 
    {
        public EmloyeeDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=EmployeeDbG011; trusted_connection=true; TrustServerCertificate=true;")
            .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
