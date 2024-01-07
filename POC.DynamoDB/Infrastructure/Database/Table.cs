using POC.DynamoDB.Infrastructure.Database.Models;
using POC.DynamoDB.Infrastructure.Database.Models.PrimitiveTypes;

namespace POC.DynamoDB.Infrastructure.Database
{
	public class Table
	{
		public readonly string Name;
		public readonly string PartitionKeyType;
		public readonly string SkType;
		public readonly Dictionary<string, string> NonKeyAttributesType;

		public Table(
			string name,
			string partitionKeyType)
		{
			Name = name;
			PartitionKeyType = partitionKeyType;
		}

		public Table(
			string name,
			string partitionKeyType,
			Dictionary<string, string> nonKeyAttributesType)
		{
			Name = name;
			PartitionKeyType = partitionKeyType;
			NonKeyAttributesType = nonKeyAttributesType;
		}

		public Table(
			string name,
			string partitionKeyType,
			string sortKeyType)
		{
			Name = name;
			PartitionKeyType = partitionKeyType;
			SkType = sortKeyType;
		}

		public Table(
			string name,
			string partitionKeyType,
			string sortKeyType,
			Dictionary<string, string> nonKeyAttributesType)
		{
			Name = name;
			PartitionKeyType = partitionKeyType;
			SkType = sortKeyType;
			NonKeyAttributesType = nonKeyAttributesType;
		}

	}
}
