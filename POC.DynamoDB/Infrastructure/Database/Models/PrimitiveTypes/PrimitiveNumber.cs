namespace POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes
{
	public class PrimitiveNumber : PrimitiveType
	{
		public decimal Value { get; set; }

		public PrimitiveNumber(decimal value)
		{
			Value = value;
		}

		public static implicit operator PrimitiveNumber(decimal value) => new PrimitiveNumber(value);
	}
}
