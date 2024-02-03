using POC.DynamoDB.Helpers.Extensions;

namespace POC.DynamoDB.Routers
{
	public static partial class Router
	{
		public static void AddRoutes(this WebApplication app)
		{
			app.MapRoute("/products").MapProducts();
		}
	}
}
