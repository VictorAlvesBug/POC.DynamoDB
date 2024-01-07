using POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes;

namespace POC.DynamoDB.Infrastructure.Database.Models
{
	public class PartitionKey<TypeOfValue> : Value<TypeOfValue> 
		where TypeOfValue : PrimitiveType
	{
		private static List<string> validTypes = new List<string>
		{
			nameof(PrimitiveString),
			nameof(PrimitiveNumber),
		};

		public PartitionKey(TypeOfValue value): base(validTypes, value) { }
	}
}
