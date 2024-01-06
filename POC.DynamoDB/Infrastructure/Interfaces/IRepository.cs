namespace POC.DynamoDB.Infrastructure.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> GetByPkAndSkAsync(string pk, string sk);
	}
}
