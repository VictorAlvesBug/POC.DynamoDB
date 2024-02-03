namespace POC.DynamoDB.Infrastructure.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<IEnumerable<TEntity>> GetAsync();
		Task<TEntity> GetAsync(string pk, string sk);
		Task<TEntity> CreateAsync(TEntity entity);
		Task<TEntity> UpdateAsync(TEntity entity);
		Task<bool> DeleteAsync(string pk, string sk);
	}
}
