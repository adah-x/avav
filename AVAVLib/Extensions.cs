using System.Text;

namespace AVAVLib
{
	/// <summary>
	/// Ein paar Helferlein um String einfacher zusammenzustöpseln
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Hängt ein Datum mit Präfix und Suffix an einen StringBuilder,
		/// wenn das Datum nicht leer ist und eine Bedingung erfüllt ist.
		/// </summary>
		/// <param name="sb">Der Stringbuilder an den angehängt wird.</param>
		/// <param name="condition">Die Bedinung, die erfüllt sein muss.</param>
		/// <param name="prefix">Das Prefix, welche im Falle des Anhängens dem Datum vorangestellt wird.</param>
		/// <param name="value">Das Datum, welches angehängt werden soll.</param>
		/// <param name="postfix">Das Suffix, welche im Falle des Anhängens dem Datum angehängt wird.</param>
		public static void AppendTokenCond(
			this StringBuilder sb,
			bool condition,
			string prefix,
			string value,
			string postfix)
		{
			if (!condition) return;
			AppendToken(sb, prefix, value, postfix);
		}
		/// <summary>
		/// Hängt ein Datum mit Präfix und Suffix an einen StringBuilder,
		/// wenn das Datum nicht leer ist.
		/// </summary>
		/// <param name="sb">Der Stringbuilder an den angehängt wird.</param>
		/// <param name="prefix">Das Prefix, welche im Falle des Anhängens dem Datum vorangestellt wird.</param>
		/// <param name="value">Das Datum, welches angehängt werden soll.</param>
		/// <param name="postfix">Das Suffix, welche im Falle des Anhängens dem Datum angehängt wird.</param>
		public static void AppendToken(
			this StringBuilder sb,
			string prefix,
			string value,
			string postfix)
		{
			if (string.IsNullOrWhiteSpace(value)) return;
			sb.Append(prefix);
			sb.Append(value);
			sb.Append(postfix);
		}

		/// <summary>
		/// Schließt einen String in zwei Tokens ein.
		/// </summary>
		/// <param name="str">Der String</param>
		/// <param name="token">Das Token</param>
		/// <returns>token+str+token</returns>
		public static string Wrap(this string str, string token)
		{
			return token + str + token;
		}
	}
}