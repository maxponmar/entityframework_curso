using NetTopologySuite.Geometries;

namespace EfCorePeliculas.Entidades
{
    public class Cine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Point Ubicacion { get; set; }
        public CineOferta CineOferta { get; set; }
        
        // La ventaje sobre una collecion o una lista de los HashSet es que son mas rapidos
        // pero con la desventaje de que no se pueden ordenar
        public HashSet<SalaDeCine> SalasDeCine { get; set; }
    }
}
