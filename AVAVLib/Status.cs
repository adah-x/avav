using System;

namespace AVAVLib
{
	/// <summary>
	/// Für die vielen verschiedenen Status, die eine Person im AV haben kann, wir ein persönlicher
	/// Trail geschrieben, jede Statusänderung ist dabei eine Datensatz, so können als Zustände
	/// (z.B. ist Bundesgeschwister, ist AH, ist JuMi) aus der geordneten Liste der Statusübergänge
	/// abgeleitet werden.
	/// </summary>
	public class Status
	{
		/// <summary>
		/// Beginnt oder endet der Status.
		/// </summary>
		public StatusChangeType StatusChangeType { get; set; }
		/// <summary>
		/// Welcher Status beginnt oder endet
		/// </summary>
		public StatusType StatusType { get; set; }
		/// <summary>
		/// Können meine Bundegeschwister diese Statusänderung sehen.
		/// </summary>
		public bool Visible { get; set; }
		/// <summary>
		/// Für welche Person gilt die Statusänderung.
		/// </summary>
		public Person Person { get; set; }
		/// <summary>
		/// TimeStamp der Zeitpunkt zu dem der Datensatz erstellt wird.
		/// Achtung: Gültig ist bezogen auf einen Statustyp immer der
		/// jüngste Datensatz, weil dieser die letzte Änderung angibt.
		/// </summary>
		public DateTime TimeStamp { get; set; } = new DateTime();
		/// <summary>
		/// Zeitpunkt zu der die Statusänderung eingetreten ist, beachte TimeStamp
		/// </summary>
		public DateTime Date { get; set; }
		/// <summary>
		/// Änderungsbeschreibung für genau diese Änderung. (Jede Änderung ist ein Datensatz.)
		/// </summary>
		public ChangeHandle ChangeHandle { get; set; }
		/// <summary>
		/// Text zur Statusänderung, Aufnahme und Beendigung eines Studiums sind auch Status
		/// hier steht dann der Studiengang drin.
		/// </summary>
		public string Text { get; set; }
	}
}