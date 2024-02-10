using POC.DynamoDB.Helpers.Extensions;
using POC.DynamoDB.Infrastructure.Database;

namespace POC.DynamoDB.Application.Dtos
{
	public class ProductToCreateDto
	{
		public string PK => Database.GetProductSchemaPK(Item);
		public string SK => Database.GetProductSchemaSK(Category);
		public string Item { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
		public int? QuantityInStock { get; set; }
		public string Image { get; set; }

		public void Validate()
		{
			if (PK.IsNullOrEmptyOrBlankSpace()) throw new ArgumentException($"Argumento '{nameof(PK)}' inválido");
			if (SK.IsNullOrEmptyOrBlankSpace()) throw new ArgumentException($"Argumento '{nameof(SK)}' inválido");
			if (Price != null && Price <= 0) throw new ArgumentException($"Argumento '{nameof(Price)}' não pode ser menor que 0.01");
			if (QuantityInStock != null && QuantityInStock < 0) throw new ArgumentException($"Argumento '{nameof(QuantityInStock)}' não pode ser negativo");
		}
	}
}
