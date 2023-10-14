using CleanArchitectureTemplate.Application.Persitence;

namespace CleanArchitectureTemplate.Application.DataContext
{
    public interface IUnitOfWork
    {
        IEntityRepository _Entities { get; }
        Task SaveChangesAsync();
    }
}
