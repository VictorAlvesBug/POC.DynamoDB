using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Application.Interfaces;
using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Helpers.Extentions;
using POC.DynamoDB.Infrastructure.Interfaces;

namespace POC.DynamoDB.Application.Services
{
	public class ProductService : IProductService
	{
		private readonly IRepository<ProductEntity> _productRepository;

        public ProductService(IRepository<ProductEntity> productRepository)
        {
			_productRepository = productRepository;
        }

		public async Task<ProductDto> GetByPkAsync(string pk)
		{
			return (await _productRepository.GetByPkAsync(pk)).ToDto();
		}

        public async Task<ProductDto> GetByPkAndSkAsync(string pk, string sk)
		{
			return (await _productRepository.GetByPkAndSkAsync(pk, sk)).ToDto();
		}
	}
}
