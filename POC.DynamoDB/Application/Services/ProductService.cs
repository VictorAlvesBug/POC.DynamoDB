using Microsoft.Extensions.Options;
using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Application.Interfaces;
using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Helpers.Extensions;
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

		public async Task<IEnumerable<ProductDto>> GetAsync()
		{
			return (await _productRepository.GetAllAsync())
				.ConvertTo<ProductDto>();
		}

		public async Task<ProductDto> GetAsync(string pk, string sk)
		{
			if (pk == null) throw new ArgumentException($"O argumento '{nameof(pk)}' é obrigatório");
			if (sk == null) throw new ArgumentException($"O argumento '{nameof(sk)}' é obrigatório");

			return (await _productRepository.GetSingleAsync(pk, sk))
				.ConvertTo<ProductDto>();
		}

		public async Task<ProductDto> CreateAsync(ProductToCreateDto productToCreateDto)
		{
			if(productToCreateDto == null) throw new ArgumentException($"O argumento '{nameof(productToCreateDto)}' é obrigatório");
			productToCreateDto.Validate();

			var productEntity = productToCreateDto.ConvertTo<ProductEntity>();
			return (await _productRepository.CreateItemAsync(productEntity))
				.ConvertTo<ProductDto>();
		}

		public async Task<ProductDto> UpdateAsync(ProductToUpdateDto productToUpdateDto)
		{
			if (productToUpdateDto == null) throw new ArgumentException($"O argumento '{nameof(productToUpdateDto)}' é obrigatório");
			productToUpdateDto.Validate();

			var productEntity = productToUpdateDto.ConvertTo<ProductEntity>();

			return (await _productRepository.UpdatePartialItemAsync(productEntity))
				.ConvertTo<ProductDto>();
		}

		public async Task DeleteAsync(string pk, string sk)
		{
			if (pk == null) throw new ArgumentException($"O argumento '{nameof(pk)}' é obrigatório");
			if (sk == null) throw new ArgumentException($"O argumento '{nameof(sk)}' é obrigatório");

			await _productRepository.DeleteAsync(pk, sk);
		}
	}
}
