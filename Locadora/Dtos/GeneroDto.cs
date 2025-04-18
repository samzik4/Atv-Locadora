using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Dtos
{
    public class GeneroDto
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public required string Nome { get; set; }
    }
}
