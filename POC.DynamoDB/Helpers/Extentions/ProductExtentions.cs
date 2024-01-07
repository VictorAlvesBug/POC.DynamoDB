using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Domain.Models.Entities;

namespace POC.DynamoDB.Helpers.Extentions
{
	public static class ProductExtentions
	{
		public static ProductDto ToDto(this ProductEntity productEntity)
		{
			if (productEntity is null)
			{
				return null;
			}

			return new ProductDto
			{
				PK = productEntity.PK,
				SK = productEntity.SK,
				Price = productEntity.Price,
				QuantityInStock = productEntity.QuantityInStock,
				Image = productEntity.Image
			};
		}

		public static IEnumerable<ProductDto> ToDto(this IEnumerable<ProductEntity> productsEntity)
		{
			return productsEntity.Select(ToDto);
		}
	}
}
