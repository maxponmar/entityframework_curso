namespace EfCorePeliculas.Entidades
{
    public class SalaDeCine
    {
        public int Id { get; set; }
        public TipoSalaDeCine TipoSalaDeCine { get; set; }

        public decimal Precio { get; set; }
        public int CindeId { get; set; }
        
        // Propiedad de navegacion
        public Cine Cine { get; set; }
        public HashSet<Pelicula> Peliculas { get; set; }
    }
}
