namespace EfCorePeliculas.Entidades
{
    public class PeliculaActor
    {
        public int PeliculaId { get; set; }
        public int ActorId { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }
        // Propiedades de navegacion
        public Pelicula Pelicula { get; set; }
        public Actor Actor { get; set; }
    }
}
