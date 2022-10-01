using Microsoft.EntityFrameworkCore;

namespace _01_ConfigurandoEfCore_Consola
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                "Server=.;Database=DemoEFCore6Udemy;Integrated Security=True");
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
