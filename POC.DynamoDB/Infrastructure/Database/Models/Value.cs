namespace POC.DynamoDB.Infrastructure.Database.Models
{
	public class Value<TypeOfValue>
	{
		private readonly string _type;
		private TypeOfValue _value;

		public Value(List<string> validTypes, TypeOfValue value)
        {
			_type = value.GetType().Name;

			if (!validTypes.Any(type => type == _type))
			{
				throw new ArgumentException($"Tipo {_type} não suportado");
			}

			_value = value;
		}

		public TypeOfValue Get() => _value;
		public void Set(TypeOfValue value) => _value = value;
	}
}
