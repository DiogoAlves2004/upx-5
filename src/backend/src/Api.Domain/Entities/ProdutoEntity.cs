using System.ComponentModel.DataAnnotations;

namespace Infra.UPX4.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public required string Nome { get; set; }

        public required long CategoriaId { get; set; }

        public required float Preco { get; set; }

        public required long QuantidadeEstoque { get; set; }

        public required string CodigoDeBarras { get; set; }

        public required long FornecedorId { get; set; }

    }
}