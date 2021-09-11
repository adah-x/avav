using System;

namespace AVAVLib
{
	/// <summary>
	/// Bild, enthält nur die Metadaten und einen Handle für den Store
	/// das einfachste sicher hier nur den relativen Pfand reinzuhängen,
	/// z.B. in der Form /AVID/Image1.jpg
	/// </summary>
	public class Image
	{
		/// <summary>
		/// Person auf dem Bild
		/// </summary>
		public Person Person { get; set; }
		/// <summary>
		/// Ist das Bild für meine Bundesgeschwister sichtbar
		/// </summary>
		public bool Visible { get; set; }
		/// <summary>
		/// Datum der Aufnahme
		/// </summary>
		public DateTime Taken { get; set; }
		/// <summary>
		/// Irgendeine Referenz auf die Datei, z.B. ein Pfad.
		/// </summary>
		public string StoreHandle { get; set; }
		/// <summary>
		/// MimeType
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Größe der Datei
		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// Hash der Datei
		/// </summary>
		public string Hash { get; set; }
	}
}