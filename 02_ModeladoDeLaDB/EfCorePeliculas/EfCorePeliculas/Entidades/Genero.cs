﻿namespace EfCorePeliculas.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public HashSet<Pelicula> Peliculas { get; set; }
    }
}
