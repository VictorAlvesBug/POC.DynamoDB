namespace POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes
{
	public class PrimitiveString : PrimitiveType
	{
		public string Value { get; set; }

		public PrimitiveString(string value)
		{
			Value = value;
		}

		public static implicit operator PrimitiveString(string value) => new PrimitiveString(value);
	}
}
