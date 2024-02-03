using Amazon.DynamoDBv2.DataModel;

namespace POC.DynamoDB.Domain.Models.Entities
{
	//[DynamoDBTable("poc-product")]
	public class ProductEntity
	{
		//[DynamoDBHashKey]
		public string PK { get; set; }

		//[DynamoDBRangeKey]
		public string SK { get; set; }
		public string Item { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public int QuantityInStock { get; set; }
		public string Image { get; set; }
	}
}
