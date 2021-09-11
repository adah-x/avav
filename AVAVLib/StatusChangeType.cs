namespace AVAVLib
{
	/// <summary>
	/// Richtungsanzeige für eine Statusänderung,
	/// Beginnt der Status mit dem Eintrag (z.B. Eintritt)
	/// oder endet dieser (z.B. Übertritt in ADAHschaft)
	/// </summary>
	public enum StatusChangeType
	{
		/// <summary>
		/// Status beginnt
		/// </summary>
		Start,
		/// <summary>
		/// Status endet
		/// </summary>
		End
	}
}