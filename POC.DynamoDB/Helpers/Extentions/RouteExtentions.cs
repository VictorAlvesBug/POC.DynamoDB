namespace POC.DynamoDB.Helpers.Extentions
{
	public static class RouteExtentions
	{
		public static RouteGroup MapRoute(
			this WebApplication app,
			string resource)
		{
			return new RouteGroup(app, resource);
		}
	}
}
