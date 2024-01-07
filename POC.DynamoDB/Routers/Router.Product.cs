using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Application.Interfaces;
using POC.DynamoDB.Helpers;
using POC.DynamoDB.Infrastructure.Database.Models;
using POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes;

namespace POC.DynamoDB.Routers
{
	public static partial class Router
	{
		public static RouteGroup MapProducts(this RouteGroup group)
		{
			group.MapGet("/", GetByPkAsync);
			group.MapGet("/SetValueString", SetValueString);
			group.MapGet("/SetValueNumber", SetValueNumber);
			group.MapGet("/SetValueBoolean", SetValueBoolean);

			return group;
		}

		public static async Task<string> SetValueString(string value)
		{
			var a = new PartitionKey<PrimitiveString>("");
			a.Set(value);
			var x = a.Get();
			return x.Value;
		}

		public static async Task<decimal> SetValueNumber(decimal value) 
		{ 
			var a = new PartitionKey<PrimitiveNumber>(0);
			a.Set(value);
			var x = a.Get();
			return x.Value;
		}

		public static async Task<bool> SetValueBoolean(bool value)
		{
			var a = new PartitionKey<PrimitiveBoolean>(false);
			a.Set(value);
			var x = a.Get();
			return x.Value;
		}

		public static async Task<ProductDto> GetByPkAsync(string pk, IProductService service)
		{
			return await service.GetByPkAsync(pk);
		}

		public static async Task<ProductDto> GetByPkAndSkAsync(string pk, string sk, IProductService service)
		{
			return await service.GetByPkAndSkAsync(pk, sk);
		}
	}
}
