using System.ComponentModel.DataAnnotations;

namespace Infra.UPX4.Domain.Entities
{
    public class FornecedorEntity : BaseEntity
    {
        public required string Nome { get; set; }

        public required string CpfCnpj { get; set; }

        public required string Telefone { get; set; }

        public required string Endereco { get; set; }

    }
}