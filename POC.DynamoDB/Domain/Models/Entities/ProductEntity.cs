using Amazon.DynamoDBv2.DataModel;
using Newtonsoft.Json.Linq;
using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Helpers.Extensions;

namespace POC.DynamoDB.Domain.Models.Entities
{
	public class ProductEntity : BaseEntity
	{
		public string Item { get; set; }
		public string Category { get; set; }
		public decimal? Price { get; set; }
		public int? QuantityInStock { get; set; }
		public string Image { get; set; }
	}
}
