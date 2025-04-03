using AutoMapper;
using Infra.UPX4.Domain.Dto;
using Infra.UPX4.Domain.Entities;
using Infra.UPX4.Domain.Interfaces.Repositories;
using Infra.UPX4.Domain.Interfaces.Services;
using Infra.UPX4.Domain.Models;

using Flunt.Notifications;

namespace Infra.UPX4.Service.Services
{
    public class FornecedorService : IFornecedorService
    {
        private IRepository<FornecedorEntity> _fornecedorRepository;
        private readonly IMapper _mapper;


        public FornecedorService(IRepository<FornecedorEntity> fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public Task<FornecedorDto> Selecionar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FornecedorDto>> Listar()
        {
            throw new NotImplementedException();
        }

        public async Task<FornecedorDto> Salvar(FornecedorDto fornecedor)
        {
            var fornecedorModel = _mapper.Map<FornecedorModel>(fornecedor);
            var fornecedorEntity = _mapper.Map<FornecedorEntity>(fornecedorModel);
            var result = await _fornecedorRepository.InsertAsync(fornecedorEntity);

            return _mapper.Map<FornecedorDto>(result);

        }

        public Task<(bool, List<Notification>)> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}