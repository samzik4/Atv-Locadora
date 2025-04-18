using ApiLocadora.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Dtos
{
    public class FilmeDto
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int AnoLancamento { get; set; }
        [Required]
        public string Diretor { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        public Estudio Estudio { get; set; }
        [Required]
        public double IMDB { get; set; }

    }
}
