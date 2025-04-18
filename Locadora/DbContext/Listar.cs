using ApiLocadora.Models;

namespace ApiLocadora.DbContext
{
    public static class Listar
    {
        public static List<Filme> Filmes = new List<Filme>();
        public static List<Estudio> Estudios { get; set; } = new List<Estudio>();
        public static List<Genero> Generos { get; set; } = new List<Genero>();

    }
}
