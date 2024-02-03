using POC.DynamoDB.Helpers.Extensions;

namespace POC.DynamoDB.Infrastructure.Database
{
	public static partial class Database
	{

		/*
			Tabela de Produtos (poc-product)
		*/

		private static string PRODUCT_SCHEMA_PK_PREFIX = "item";
		private static string PRODUCT_SCHEMA_SK_PREFIX = "category";
		public static string GetProductSchemaPK(string item) => 
			Hyphenize(PRODUCT_SCHEMA_PK_PREFIX, item.RemoverAcentos().ToLower().Split(" "));
		public static string GetProductSchemaSK(string category) => 
			Hyphenize(PRODUCT_SCHEMA_SK_PREFIX, category.RemoverAcentos().ToLower().Split(" "));
	}
}
