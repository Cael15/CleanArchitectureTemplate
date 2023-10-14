using CleanArchitectureTemplate.Application.DataContext;
using CleanArchitectureTemplate.Application.Persitence;
using CleanArchitectureTemplate.Persistence.Repositories;

namespace CleanArchitectureTemplate.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DapperContext _context;
        private IEntityRepository Entities;
        
        public UnitOfWork(DapperContext context)
        {
            _context = context;
        }

        public IEntityRepository _Entities => Entities = Entities ?? new EntityRepository(_context);
        public async Task SaveChangesAsync()
        {
            using var connection = _context.CreateConnection();
        }
    }
}
