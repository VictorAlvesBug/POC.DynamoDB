using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Infrastructure.Interfaces;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.AspNetCore.Http;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;

namespace POC.DynamoDB.Infrastructure.Repositories
{
	public class ProductRepository : IRepository<ProductEntity>
	{
		private readonly IDynamoDBContext _context;

		public ProductRepository(IDynamoDBContext context)
		{
			_context = context;
		}

		public virtual async Task<ProductEntity> GetByPkAndSkAsync(string pk, string sk)
		{
			return await _context.LoadAsync<ProductEntity>(pk, sk);
		}

		/*
		 
		var client = new AmazonDynamoDBClient();



			var tableName = "poc-product";
			var primaryKeyValue = "Item-5cf0370f0b2a43ddb8a45c6fbe7c1d97";

			var sortKeyValue = "Notebook Dell Inspiron 15";

			var table = Table.LoadTable(client, tableName);

			var queryFilter = new QueryFilter();
			queryFilter.AddCondition("PK", QueryOperator.Equal, primaryKeyValue);
			queryFilter.AddCondition("SK", QueryOperator.Equal, sortKeyValue);
			queryFilter.AddCondition("QuantityInStock", QueryOperator.Equal, "100");

			var search = table.Query(queryFilter);

			List<Document> items = new List<Document>();
			do
			{
				var set = await search.GetNextSetAsync();
				items.AddRange(set);
			} while (!search.IsDone);

			foreach (var item in items)
			{
				// Processar os itens retornados
				var itemData = item.ToJsonPretty();
				Console.WriteLine(itemData);
			}



			return new ProductEntity { PK = pk, SK = sk };
		 
		 */

	}
}
