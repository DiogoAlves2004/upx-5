using System.ComponentModel.DataAnnotations;

namespace Infra.UPX4.Domain.Models
{
    public class ProdutoModel
    {
        public Guid Id { get; set; }

        public  string Nome { get; set; }

        public  long CategoriaId { get; set; }

        public  float Preco { get; set; }

        public  long QuantidadeEstoque { get; set; }

        public  string CodigoDeBarras { get; set; }

        public  long FornecedorId { get; set; }
    }
}
