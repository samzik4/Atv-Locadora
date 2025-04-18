using ApiLocadora.Models;

namespace ApiLocadora
{
    public class Filme
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public string Diretor { get; set; }
        public Genero Genero { get; set; }
        public Estudio Estudio { get; set; }
        public double IMDB { get; set; }
    }
}
