namespace AVAVLib
{
	/// <summary>
	/// Art der Adresse oder Arbeitgebers
	/// </summary>
	public enum AddressValidityType
	{
		/// <summary>
		/// Addresse der Eltern während des Studiums
		/// </summary>
		Home,
		/// <summary>
		/// Hauptwohnsitz
		/// </summary>
		Main,
		/// <summary>
		/// Nebenwohnsitz
		/// </summary>
		Other,
		/// <summary>
		/// Arbeitgeber
		/// </summary>
		Employer,
		/// <summary>
		/// Zeitlich begrenzt
		/// </summary>
		Temporary
	}
}