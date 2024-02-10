using POC.DynamoDB.Domain.Models.Entities;

namespace POC.DynamoDB.Infrastructure.Interfaces
{
	public interface IRepository<TEntity> where TEntity : BaseEntity
	{
		Task<IEnumerable<TEntity>> GetAllAsync();
		Task<TEntity> GetSingleAsync(string PK, string SK);
		Task<TEntity> CreateItemAsync(TEntity entity);
		Task<TEntity> UpdateWholeItemAsync(TEntity entity);
		Task<TEntity> UpdatePartialItemAsync(TEntity entity);
		Task DeleteAsync(string PK, string SK);
	}
}
