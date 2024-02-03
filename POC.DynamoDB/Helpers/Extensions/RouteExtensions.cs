namespace POC.DynamoDB.Helpers.Extensions
{
	public static class RouteExtensions
	{
		public static RouteGroup MapRoute(
			this WebApplication app,
			string resource)
		{
			return new RouteGroup(app, resource);
		}
	}
}
