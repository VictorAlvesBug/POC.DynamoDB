namespace POC.DynamoDB.Helpers
{
	public class RouteGroup
	{
		private readonly WebApplication _app;
		private readonly string _resource;

		public RouteGroup(WebApplication app, string resource)
		{
			_app = app;
			_resource = resource;
		}

		public void MapGet(string path, Delegate Delegate)
			=> _app.MapGet($"{_resource}{path}", Delegate);

		public void MapPost(string path, Delegate Delegate)
			=> _app.MapPost($"{_resource}{path}", Delegate);

		public void MapPut(string path, Delegate Delegate)
			=> _app.MapPut($"{_resource}{path}", Delegate);

		public void MapDelete(string path, Delegate Delegate)
			=> _app.MapDelete($"{_resource}{path}", Delegate);
	}
}
