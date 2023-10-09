using CleanArchitectureTemplate.Application.DataContext;
using CleanArchitectureTemplate.Application.Persitence;
using CleanArchitectureTemplate.Persistence.Repositories;

namespace CleanArchitectureTemplate.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleanAquitectureTemplateContext _dbContext;
        private IEntityRepository Entities;
        
        public UnitOfWork(CleanAquitectureTemplateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEntityRepository _Entities => Entities = Entities ?? new EntityRepository(_dbContext);
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }


    }
}
