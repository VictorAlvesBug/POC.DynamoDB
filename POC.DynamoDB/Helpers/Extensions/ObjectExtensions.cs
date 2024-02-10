﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
			Culture = CultureInfo.CurrentCulture,
			TypeNameHandling = TypeNameHandling.All,
			NullValueHandling = NullValueHandling.Ignore,
		};

		public static string ToJson(this object obj) =>
			JsonConvert.SerializeObject(obj, DefaultSettings);

		public static ObjectType MergeWith<ObjectType>(this ObjectType currentObject, ObjectType otherObject)
		{
			var current = JObject.Parse(currentObject.ToJson());
			var other = JObject.Parse(otherObject.ToJson());

			foreach (var property in other)
			{
				if (property.Value != null)
				{
					current[property.Key] = property.Value;
				}
			}

			return JsonConvert.DeserializeObject<ObjectType>(current.ToString(), DefaultSettings);
		}
	}
}
