using Flunt.Notifications;
using Infra.UPX4.Domain.Dto;



namespace Infra.UPX4.Domain.Interfaces.Services
{
    public interface IFornecedorService
    {
        Task<FornecedorDto> Selecionar(Guid id);

        Task<IEnumerable<FornecedorDto>> Listar();
        
        Task<FornecedorDto> Salvar(FornecedorDto forncedor);
        
        Task<(bool, List<Notification>)> Excluir(Guid id);

    }
}