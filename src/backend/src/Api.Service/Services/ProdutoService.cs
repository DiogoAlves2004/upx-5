using AutoMapper;
using Infra.UPX4.Domain.Dto;
using Infra.UPX4.Domain.Entities;
using Infra.UPX4.Domain.Interfaces.Repositories;
using Infra.UPX4.Domain.Interfaces.Services;
using Infra.UPX4.Domain.Models;

using Flunt.Notifications;

namespace Infra.UPX4.Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private IRepository<ProdutoEntity> _pontoDeAcessibilidadeRepository;
        private readonly IMapper _mapper;


        public ProdutoService(IRepository<ProdutoEntity> produtoRepository, IMapper mapper)
        {
            _pontoDeAcessibilidadeRepository = produtoRepository;
            _mapper = mapper;
        }

        public Task<ProdutoDto> Selecionar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoDto>> Listar()
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoDto> Salvar(ProdutoDto ponto)
        {
            var pontoModel = _mapper.Map<ProdutoModel>(ponto);
            var pontoEntity = _mapper.Map<ProdutoEntity>(pontoModel);
            var result = await _pontoDeAcessibilidadeRepository.InsertAsync(pontoEntity);

            return _mapper.Map<ProdutoDto>(result);

        }

        public Task<(bool, List<Notification>)> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}