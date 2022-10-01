using Microsoft.EntityFrameworkCore;

namespace _02_ConfigurandoEFCore_MVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
