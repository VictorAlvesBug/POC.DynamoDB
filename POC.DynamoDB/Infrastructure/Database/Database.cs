using POC.DynamoDB.Helpers.Extensions;

namespace POC.DynamoDB.Infrastructure.Database
{
	public static partial class Database
	{
		public static string Hyphenize(params string[] parts)
		{
			if (parts.Length == 0)
				return string.Empty;

			return string.Join("-", parts);
		}

		public static string Hyphenize(string prefix, params string[] parts)
		{
			if (prefix.IsNullOrEmptyOrBlankSpace())
				return Hyphenize(parts);

			return $"{prefix}-{Hyphenize(parts)}";
		}
	}
}
