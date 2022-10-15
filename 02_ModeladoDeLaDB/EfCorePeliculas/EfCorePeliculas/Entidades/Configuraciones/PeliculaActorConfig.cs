using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EfCorePeliculas.Entidades.Configuraciones
{
    public class PeliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder)
        {
            builder.HasKey(x => new { x.ActorId, x.PeliculaId });
            builder.Property(x => x.Personaje)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
