using Flunt.Notifications;
using Infra.UPX4.Domain.Dto;



namespace Infra.UPX4.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Task<ProdutoDto> Selecionar(Guid id);

        Task<IEnumerable<ProdutoDto>> Listar();
        
        Task<ProdutoDto> Salvar(ProdutoDto user);
        
        Task<(bool, List<Notification>)> Excluir(Guid id);

    }
}