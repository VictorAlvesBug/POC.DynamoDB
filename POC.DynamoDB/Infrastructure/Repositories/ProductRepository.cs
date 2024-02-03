using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Infrastructure.Interfaces;
using POC.DynamoDB.Helpers.Extensions;
using POC.DynamoDB.Helpers.Utils;

namespace POC.DynamoDB.Infrastructure.Repositories
{
	public class ProductRepository : IRepository<ProductEntity>
	{
		private readonly IDynamoDBContext _context;
		private readonly string _tableName = "poc-product";
		private readonly Table _table;

		public ProductRepository(IDynamoDBContext context)
		{
			_context = context;
			_table = DynamoUtils.GetTable(_tableName);
		}

		public virtual async Task<IEnumerable<ProductEntity>> GetAsync()
		{
			ScanFilter filter = new ScanFilter();

			Search search = _table.Scan(filter);
			List<Document> results = await search.GetNextSetAsync();

			return results.ConvertTo<ProductEntity>();
		}

		public virtual async Task<ProductEntity> GetAsync(string pk, string sk)
		{
			QueryFilter filter = new QueryFilter("PK", QueryOperator.Equal, pk);
			filter.AddCondition("SK", QueryOperator.Equal, sk);

			QueryOperationConfig queryConfig = new QueryOperationConfig
			{
				Filter = filter
			};

			Search search = _table.Query(queryConfig);
			List<Document> results = await search.GetNextSetAsync();

			return results.ConvertTo<ProductEntity>().FirstOrDefault();
		}

		public virtual async Task<ProductEntity> CreateAsync(ProductEntity productEntity)
		{
			Document document = productEntity.ToDocument();

			await _table.PutItemAsync(document);

			return productEntity;
		}

		public virtual async Task<ProductEntity> UpdateAsync(ProductEntity entity)
		{
			throw new NotImplementedException();
		}

		public virtual async Task<bool> DeleteAsync(string pk, string sk)
		{
			throw new NotImplementedException();
		}
	}
}
