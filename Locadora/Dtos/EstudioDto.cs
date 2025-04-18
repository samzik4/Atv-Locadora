using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Dtos
{
    public class EstudioDto
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Distribuidora { get; set; }
    }
}
