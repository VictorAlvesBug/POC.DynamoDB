using System.Globalization;
using System.Text;

namespace POC.DynamoDB.Helpers.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNullOrEmptyOrBlankSpace(this string text)
		{
			return string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text);
		}

		public static string RemoverAcentos(this string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return text;
			}

			string normalizedString = text.Normalize(NormalizationForm.FormD);
			StringBuilder sb = new StringBuilder();

			foreach (char c in normalizedString)
			{
				if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
				{
					sb.Append(c);
				}
			}

			return sb.ToString().Normalize(NormalizationForm.FormC);
		}

		public static bool In(this string text, params string[] items) => items.Any(item => text == item);

		public static bool NotIn(this string text, params string[] items) => !text.In(items);
	}
}
