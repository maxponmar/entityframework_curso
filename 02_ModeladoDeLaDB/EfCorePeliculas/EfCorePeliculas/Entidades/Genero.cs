using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCorePeliculas.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
