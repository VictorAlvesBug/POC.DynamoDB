using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace POC.DynamoDB.Initializers
{
	public static class DynamoDbInitializer
	{
		public static void Initialize(WebApplicationBuilder builder) {
			var awsOptions = builder.Configuration.GetAWSOptions();
			builder.Services.AddDefaultAWSOptions(awsOptions);
			builder.Services.AddAWSService<IAmazonDynamoDB>();
			builder.Services.AddScoped<IDynamoDBContext, DynamoDBContext>();
		}
	}
}
