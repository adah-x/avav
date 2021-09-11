using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AVAVLib
{
	public partial class PersonData
	{
		/// <summary>
		/// Geburtstag im Jahr, Beispielcode für die Sortierte Darstellung im Mitgliederverzeichnis
		/// </summary>
		public DateTime? BirthdayInYear
		{
			get
			{
				if (!IsBirthdayVisible) return null;
				if (Birthday == null) return null;
				return new DateTime(1900, Birthday.Value.Month, Birthday.Value.Day) +
				       TimeSpan.FromSeconds((double)Birthday.Value.Year); // Sortierreihenfolge!
			}
		}

		private string _displayName;
		/// <summary>
		/// Sample Code - Vollständiger Name der Person
		/// </summary>
		public string DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					if (string.IsNullOrWhiteSpace(Name))
						throw
							new Exception(@"We need at least a 'Name' to generate a display name, but we got none.");
					StringBuilder res = new StringBuilder();
					res.AppendToken("", this.PrefixTitle, " ");
					res.AppendToken("", GivenNamePrefix, " ");
					res.AppendToken("", GivenName, " ");
					res.AppendToken("", AdditionalNames, " ");
					res.AppendToken("\"", Nickname, "\" ");
					res.AppendToken("", NamePrefix, " ");
					res.AppendToken("\\textbf{", Name, "}");
					res.AppendToken(" ", NameSuffix, "");
					res.AppendToken(", ", SuffixTitle, "");
					res.AppendToken(" (", StaatsexamenProfession, ")");
					res.AppendToken(", geb. ", MaidenName, "");
					_displayName = res.ToString();
				}
				return _displayName;
			}
		}

		private string _displayShortName = null;
		/// <summary>
		/// Sample Code - Kurzer Name der Person zur Anzeige
		/// </summary>
		public string DisplayShortName
		{
			get
			{
				if (_displayShortName == null)
				{
					if (string.IsNullOrWhiteSpace(Name))
						throw
							new Exception(@"We need at least a 'Name' to generate a display name, but we got none.");
					StringBuilder res = new StringBuilder();
					res.AppendToken("", GivenNamePrefix, " ");
					res.AppendToken("", GivenName, " ");
					res.AppendToken("", NamePrefix, " ");
					res.AppendToken("\\textbf{", Name, "}");
					res.AppendToken(" ", NameSuffix, "");
					res.AppendToken(", geb. ", MaidenName, "");
					_displayShortName = res.ToString();
				}
				return _displayShortName;
			}
		}
		/// <summary>
		/// Sample Code, ermittelt die EMail-Addressen als Liste.
		/// </summary>
		public IEnumerable<string> EMails
		{
			get
			{
				if (EMailOfficial != null) yield return EMailOfficial;
				if (EMailStuff != null && 
				    EMailStuff.ToLower().Trim() != 
				    EMailOfficial.ToLower().Trim()) yield return EMailStuff;
			}
		}
		/// <summary>
		/// Sample Code - Interner Anzeigename der Person mit EMails
		/// </summary>
		public string DisplayInternalWithEMails => 
			DisplayInternal + "<" + string.Join(">;<", EMails) + ">";
		/// <summary>
		/// Sample Code - Interner Anzeigename der Person
		/// </summary>
		public string DisplayInternal => Name + ", " + GivenName + " [" + Person.Avid + "] " +
		                                 "(" + Birthday?.ToString("dd.MM.yyyy") + ")";


	}
}
