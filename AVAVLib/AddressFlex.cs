using System.Linq;

namespace AVAVLib
{
	public partial class Address
	{
		/// <summary>
		/// Sample Code um die aktuell gültige Version zu bekommen.
		/// </summary>
		public AddressVersion ValidVersion =>
			AddressVersions
				.Where(av => av.Valid)
				.OrderBy(av => av.TimeStamp)
				.LastOrDefault();
		/// <summary>
		/// Sample Code um die letzte Version zu bekommen. Ist diese vom Mitglied eingegeben,
		/// ist sie schwebend und unterscheidet sich von der letzten gültigen Version.
		/// </summary>
		public AddressVersion LatestVersion =>
			AddressVersions
				.OrderBy(av => av.TimeStamp)
				.LastOrDefault();
	}
}