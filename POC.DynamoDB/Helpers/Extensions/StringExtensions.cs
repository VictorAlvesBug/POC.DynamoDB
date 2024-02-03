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

		public static string RemoverAcentos(this string texto)
		{
			if (string.IsNullOrEmpty(texto))
			{
				return texto;
			}

			string normalizedString = texto.Normalize(NormalizationForm.FormD);
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
	}
}
