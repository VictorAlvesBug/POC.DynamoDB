namespace POC.DynamoDB.Infrastructure.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> GetByPkAsync(string pk);
		Task<TEntity> GetByPkAndSkAsync(string pk, string sk);
	}
}
