using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Infrastructure.Interfaces;

namespace POC.DynamoDB.Infrastructure.Repositories
{
	public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
	{
		private readonly static string _tableName = "poc-product";

		public ProductRepository() : base(_tableName)
		{

		}
	}
}
