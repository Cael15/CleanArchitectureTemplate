using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Application.Persitence
{
    public interface IEntityRepository
    {
        Task<IEnumerable<Entity>> GetAllEntityAsync();
        Task InsertEntityAsync(Entity entity);
    }
}
