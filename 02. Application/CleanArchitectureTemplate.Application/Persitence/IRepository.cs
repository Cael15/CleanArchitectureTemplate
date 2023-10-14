namespace CleanArchitectureTemplate.Application.Persitence
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
    }
}
