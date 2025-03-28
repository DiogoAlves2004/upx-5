using System.ComponentModel.DataAnnotations;

namespace Infra.UPX4.Domain.Dto
{
    public class ProdutoDto
    {

        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        public long CategoriaId { get; set; }

        [Required]
        public float Preco { get; set; }

        [Required]
        public long QuantidadeEstoque { get; set; }

        [Required]
        public string CodigoDeBarras { get; set; }

        [Required]
        public long FornecedorId { get; set; }

    }
}
