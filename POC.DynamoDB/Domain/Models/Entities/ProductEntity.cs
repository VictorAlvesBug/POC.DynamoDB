using Amazon.DynamoDBv2.DataModel;

namespace POC.DynamoDB.Domain.Models.Entities
{
	[DynamoDBTable("poc-product")]
	public class ProductEntity
	{
		public string PK { get; set; }
		public string SK { get; set; }
		public decimal Price { get; set; }
		public int QuantityInStock { get; set; }
		public string? Image { get; set; }
	}
}
