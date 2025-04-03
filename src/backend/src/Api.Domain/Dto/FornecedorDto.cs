using System.ComponentModel.DataAnnotations;

namespace Infra.UPX4.Domain.Dto
{
    public class FornecedorDto
    {

        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(20)]
        public required string CpfCnpj { get; set; }

        [Required]
        [MaxLength(20)]
        public required string Telefone { get; set; }

        [Required]
        [MaxLength(500)]
        public required string Endereco { get; set; }

    }
}
