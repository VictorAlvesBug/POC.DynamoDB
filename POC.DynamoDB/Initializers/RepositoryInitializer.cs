using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Infrastructure.Interfaces;
using POC.DynamoDB.Infrastructure.Repositories;

namespace POC.DynamoDB.Initializers
{
	public static class RepositoryInitializer
	{
		public static void Initialize(WebApplicationBuilder builder)
		{
			builder.Services.AddScoped<IRepository<ProductEntity>, ProductRepository>();
		}
	}
}
