using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;

namespace POC.DynamoDB.Helpers.Utils
{
	public static class DynamoUtils
	{
		public static Table GetTable(string tableName)
		{
			var _awsAccessKey = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY");
			var _awsSecretKey = Environment.GetEnvironmentVariable("AWS_SECRET_KEY");

			var config = new AmazonDynamoDBConfig
			{
				RegionEndpoint = Amazon.RegionEndpoint.SAEast1
			};

			var client = new AmazonDynamoDBClient(_awsAccessKey, _awsSecretKey, config);
			Table table = Table.LoadTable(client, tableName);

			if (table == null)
				throw new Exception("Tabela não encontrada no DynamoDB");

			return table;
		}
	}
}
