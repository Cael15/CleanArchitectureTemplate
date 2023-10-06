using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Application.Services
{
    public interface IEntityService
    {
        Task<Entity> GetAllEntityAsync(int id);
    }
}
