using POC.DynamoDB.Application.Interfaces;
using POC.DynamoDB.Application.Services;

namespace POC.DynamoDB.Initializers
{
	public static class ServiceInitializer
	{
		public static void Initialize(WebApplicationBuilder builder)
		{
			builder.Services.AddScoped<IProductService, ProductService>();
		}
	}
}
