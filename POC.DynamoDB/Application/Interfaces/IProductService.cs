using Amazon.DynamoDBv2.Model;
using POC.DynamoDB.Application.Dtos;

namespace POC.DynamoDB.Application.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<ProductDto>> GetAsync();
		Task<ProductDto> GetAsync(string pk, string sk);
		Task<ProductDto> CreateAsync(ProductToCreateDto productToCreateDto);
		Task<ProductDto> UpdateAsync(ProductToUpdateDto productToUpdateDto);
		Task<bool> DeleteAsync(string pk, string sk);
	}
}
