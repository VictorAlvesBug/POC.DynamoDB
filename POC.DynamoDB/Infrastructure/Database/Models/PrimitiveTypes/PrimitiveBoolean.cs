namespace POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes
{
	public class PrimitiveBoolean : PrimitiveType
	{
		public bool Value { get; set; }

        public PrimitiveBoolean(bool value)
        {
                Value = value;
		}

		public static implicit operator PrimitiveBoolean(bool value) => new PrimitiveBoolean(value);
	}
}
