using System;

namespace AVAVLib
{
	/// <summary>
	/// Person zu Person Relation mit Gültigkeit
	///
	/// Für die Serialisierung eindeutig über From.AVID und To.AVID beschreibbar.
	///
	/// Gültig ist immer nur der Jüngste Datensatz.
	///
	/// Inkonsistenzen sollte nur der zeitversetzte Validator prüfen.
	/// z.B. Geschwister in beide Richungen
	/// Enkel und Großelter jeweils in entgegensetzter Richtung.
	/// </summary>
	public partial class Relation
	{
		/// <summary>
		/// Ausgangpunkt
		/// </summary>
		public Person From { get; set; }
		/// <summary>
		/// Zielpunkt
		/// </summary>
		public Person To { get; set; }
		/// <summary>
		/// TimeStamp mit der Systemzeit zum Erstellungszeitpunkt.
		/// </summary>
		public DateTime TimeStamp { get; set; } = DateTime.Now;
		/// <summary>
		/// Gültig von
		/// </summary>
		public DateTime ValidFrom { get; set; } = DateTime.MinValue;
		/// <summary>
		/// Gültig bis
		/// </summary>
		public DateTime ValidTill { get; set; } = DateTime.MaxValue;
		/// <summary>
		/// Änderungsbeschreibung für genau diese Änderung. (Jede Änderung ist ein Datensatz.)
		/// </summary>
		public ChangeHandle ChangeHandle { get; set; }
	}
}