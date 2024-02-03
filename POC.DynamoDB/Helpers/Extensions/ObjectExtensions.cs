using Newtonsoft.Json;
using POC.DynamoDB.Helpers.Utils;
using System.Globalization;

namespace POC.DynamoDB.Helpers.Extensions
{
	public static class ObjectExtensions
	{
		private readonly static JsonSerializerSettings DefaultSettings = new()
		{
			Formatting = Formatting.None,
			ContractResolver = new JsonIgnorePropertyContractResolver(),
			TypeNameHandling = TypeNameHandling.All,
			NullValueHandling = NullValueHandling.Ignore,
		};

		public static string ToJson(this object obj) => 
			JsonConvert.SerializeObject(obj, DefaultSettings);
	}
}
