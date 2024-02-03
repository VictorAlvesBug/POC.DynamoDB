using Microsoft.AspNetCore.Mvc;
using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Application.Interfaces;
using POC.DynamoDB.Helpers;

namespace POC.DynamoDB.Routers
{
	public static partial class Router
	{
		public static RouteGroup MapProducts(this RouteGroup group)
		{
			group.MapGet($"/{nameof(GetAll)}", GetAll);
			group.MapGet($"/{nameof(Get)}", Get);
			group.MapPost($"/{nameof(Create)}", Create);
			group.MapPost($"/{nameof(Update)}", Update);
			group.MapDelete($"/{nameof(Delete)}", Delete);
			return group;
		}

		public static async Task<IEnumerable<ProductDto>> GetAll(IProductService service)
		{
			return await service.GetAsync();
		}

		public static async Task<ProductDto> Get(string pk, string sk, IProductService service)
		{
			return await service.GetAsync(pk, sk);
		}

		public static async Task<ProductDto> Create([FromBody] ProductToCreateDto productToCreateDto, IProductService service)
		{
			return await service.CreateAsync(productToCreateDto);
		}

		public static async Task<ProductDto> Update([FromBody] ProductToUpdateDto productToUpdateDto, IProductService service)
		{
			return await service.UpdateAsync(productToUpdateDto);
		}

		public static async Task<bool> Delete(string pk, string sk, IProductService service)
		{
			return await service.DeleteAsync(pk, sk);
		}
	}
}
