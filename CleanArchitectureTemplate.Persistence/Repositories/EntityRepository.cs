using CleanArchitectureTemplate.Application.Persitence;
using CleanArchitectureTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureTemplate.Persistence.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly CleanAquitectureTemplateContext _dbContext;

        public EntityRepository(CleanAquitectureTemplateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Entity entity)
        {
            await _dbContext.Entities.AddAsync(entity);
        }
        public async Task<IEnumerable<Entity>> GetAllEntityAsync()
        {
            return await  _dbContext.Entities
                .ToListAsync();
        }
    }
}
