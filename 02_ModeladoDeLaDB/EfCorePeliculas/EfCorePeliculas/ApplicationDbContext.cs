using EfCorePeliculas.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genero>().HasKey(x => x.Id);

            modelBuilder.Entity<Genero>().Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Actor>().HasKey(x => x.Id);
            modelBuilder.Entity<Actor>().Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(x => x.FechaNacimiento)
                .HasColumnType("date");

            modelBuilder.Entity<Cine>().Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Cine>().Property(x => x.Precio)
                .HasPrecision(precision: 9, scale: 2);

            modelBuilder.Entity<Pelicula>().Property(x => x.Titulo)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Pelicula>().Property(x => x.FechaEstreno)
                .HasColumnType("date");

            modelBuilder.Entity<Pelicula>().Property(x => x.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
        
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
