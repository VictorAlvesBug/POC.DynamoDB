using POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes;

namespace POC.DynamoDB.Infrastructure.Database
{
	public static partial class Database
	{
		public static Table PocProduct = new(
			name: "poc-product", 
			partitionKeyType: nameof(PrimitiveString), 
			sortKeyType: nameof(PrimitiveString),
			nonKeyAttributesType: new Dictionary<string, string>
			{
				{ "Image", nameof(PrimitiveString) },
				{ "Price", nameof(PrimitiveNumber) },
				{ "QuantityInStock", nameof(PrimitiveNumber) },
			});
	}
}
