using CleanArchitectureTemplate.Application.Persitence;
using CleanArchitectureTemplate.Domain.Entities;
using Dapper;
using System.Data;

namespace CleanArchitectureTemplate.Persistence.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly DapperContext _context;

        public EntityRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entity>> GetAllEntityAsync()
        {
            var query = "SELECT * FROM Entities";

            using(var connecion = _context.CreateConnection())
            {
                var entities = await connecion.QueryAsync<Entity>(query);
                return entities.ToList();
            }
        }

        public async Task InsertEntityAsync(Entity entity)
        {
            try
            {
                var query = "INSERT INTO Entities (Id, Name, LastName, Age, Price, CreatedAt, IsActive) " +
                "VALUES (@Id, @Name, @LastName, @Age, @Price, @CreatedAt, @IsActive)";

                var parameters = new DynamicParameters(entity.GetType().Name);
                parameters.Add("Id", entity.Id, DbType.Guid);
                parameters.Add("Name", entity.Name, DbType.String);
                parameters.Add("LastName", entity.LastName, DbType.String);
                parameters.Add("Age", entity.Age, DbType.Int32);
                parameters.Add("Price", entity.Price, DbType.Decimal);
                parameters.Add("CreatedAt", entity.CreatedAt, DbType.DateTime);
                parameters.Add("IsActive", entity.IsActive, DbType.Boolean);

                using (var connecion = _context.CreateConnection())
                {
                    await connecion.ExecuteAsync(query, parameters);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
