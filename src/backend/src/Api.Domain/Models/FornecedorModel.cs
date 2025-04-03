using System.ComponentModel.DataAnnotations;

namespace Infra.UPX4.Domain.Models
{
    public class FornecedorModel
    {
        public Guid Id { get; set; }

        public  string Nome { get; set; }

        public  string CpfCnpj { get; set; }

        public  string Telefone { get; set; }

        public  string Endereco { get; set; }
    }
}
