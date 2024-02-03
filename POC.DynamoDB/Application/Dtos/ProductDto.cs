namespace POC.DynamoDB.Application.Dtos
{
	public class ProductDto
	{
		public string PK { get; set; }
		public string SK { get; set; }
		public string Item { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public int QuantityInStock { get; set; }
		public string Image { get; set; }
	}
}
