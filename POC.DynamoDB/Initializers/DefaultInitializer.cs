namespace POC.DynamoDB.Initializers
{
	public static class DefaultInitializer
	{
		public static void Initialize(WebApplicationBuilder builder)
		{
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
		}
	}
}
