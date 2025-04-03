using Infra.UPX4.Data.Context;
using Infra.UPX4.Domain.Entities;
using Infra.UPX4.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Infra.UPX4.Data.Repository
{
    public class FornecedorRepository : BaseRepository<FornecedorEntity>, IFornecedorRepository
    {
        private DbSet<FornecedorEntity> _dataset;

        public FornecedorRepository(MyContext context) : base(context)
        {
            _dataset = _context.Set<FornecedorEntity>();
        }

    }
}