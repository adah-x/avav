using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVAVLib
{
	public partial class Person
	{
		/// <summary>
		/// Sample Code - Ermittelt, ob ein bestimmter Status für alle sichtbar sein soll.
		/// </summary>
		/// <param name="statusType">Status, der geprüft werden soll.</param>
 		/// <param name="changeType">Statusänderungsrichtung</param>
		/// <returns>true für sichtbar</returns>

		public bool IsVisibleStatus(StatusType statusType, StatusChangeType changeType)
		{
			return Status
				       .Where(s => 
					       s.StatusType == statusType
					       &&
					       s.StatusChangeType == changeType)
				       .OrderBy(s => s.Date)
				       .LastOrDefault()?.Visible ?? false;
		}
		/// <summary>
		/// Sample Code - Ermittelt, das letzte Datum einer Statusänderung
		/// </summary>
		/// <param name="statusType">Status, der geprüft werden soll.</param>
		/// <param name="changeType">Statusänderungsrichtung</param>
		/// <returns>Das Datum der Änderung</returns>
		public DateTime? StatusDate(StatusType statusType, StatusChangeType changeType)
		{
			return Status
				.Where(s => 
					s.StatusType == statusType
					&&
					s.StatusChangeType == changeType)
				       .OrderBy(s => s.Date)
				       .LastOrDefault()?.Date;
		}

		/// <summary>
		/// Sample Code um die aktuell gültige Version zu bekommen.
		/// </summary>
		public PersonData ValidData =>
		PersonData.Where(pd=>pd.Valid)
			.OrderBy(pd => pd.TimeStamp).LastOrDefault();

		/// <summary>
		/// Sample Code um die letzte Version zu bekommen. Ist diese vom Mitglied eingegeben,
		/// ist sie schwebend und unterscheidet sich von der letzten gültigen Version.
		/// </summary>
		public PersonData LatestData =>
			PersonData.OrderBy(pd => pd.TimeStamp).LastOrDefault();

		/// <summary>
		/// Sample Code zur Ermittlung der sichtbaren Addressen. Diese sind stets nur die gültigen.
		/// </summary>
		public IEnumerable<Address> DisplayAddresses =>
			Addresses
				.Where(
					av => av.Visible
					      &&
					      av.ValidFrom < DateTime.Now
					      &&
					      av.ValidTill > DateTime.Now
					      &&
					      av.AddressValidityType != AddressValidityType.Employer
				).GroupBy(av => av.Address.Adid)
				.Select(
					g => g.OrderBy(c => c.TimeStamp).Last())
				.Select(ad => ad.Address);

		/// <summary>
		/// Sample Code zur Ermittlung der sichtbaren Postleitzahlen.
		/// Wird zur Erstellung der nach Postleitzahlen sortierten Übersicht
		/// im MV verwendet.
		/// </summary>
		public IEnumerable<string> DisplayPostCodes =>
			DisplayAddresses
				.Select(
					a => a.ValidVersion.CountryCode + "-" + a.ValidVersion.PostCode);

		/// <summary>
		/// Sample Code - Shortcut zum gültigen vollständigen Namen
		/// </summary>
		public string DisplayName => ValidData.DisplayName;
		/// <summary>
		/// Sample Code - Shortcut zum gültigen kurzen Namen
		/// </summary>
		public string DisplayShortName => ValidData.DisplayShortName;
		/// <summary>
		/// Sample Code - Shortcut zur internen Darstellung mit EMail-Adressen
		/// </summary>
		public string DisplayInternalWithEMails => ValidData.DisplayInternalWithEMails;
		/// <summary>
		/// Sample Code - Shortcut zur internen Darstellung
		/// </summary>
		public string DisplayInternal => ValidData.DisplayInternal;

		/// <summary>
		/// Sample Code - Ermittelt die Studiengänge
		/// </summary>
		public IEnumerable<string> FieldsOfStudies =>
			Status.Where(s => s.StatusType == StatusType.FieldOfStudy)
				.OrderBy(s => s.Date)
				.Select(s => s.Text).Distinct();
		/// <summary>
		/// Sample Code - Ermittelt den Studienbeginn
		/// </summary>
		public DateTime? StartOfStudies =>
			Status.Where(s => s.StatusType == StatusType.FieldOfStudy)
				.OrderBy(s => s.Date)
				.Select(s=>s.Date)
				.FirstOrDefault();
		/// <summary>
		/// Sample Code - Ermittelt das Studienende
		/// </summary>
		public DateTime? EndOfStudies =>
			Status.Where(s => s.StatusType == StatusType.FieldOfStudy)
				.OrderBy(s => s.Date)
				.Select(s => s.Date)
				.LastOrDefault();

		/// <summary>
		/// Sample Code - Ermittelt die aktuellen Arbeitgeber
		/// </summary>
		public IEnumerable<Address> Employers =>
			Addresses.Where(av =>
				av.AddressValidityType == AddressValidityType.Employer
				&&
				av.ValidFrom < DateTime.Now
				&&
				av.ValidTill > DateTime.Now).Select(a => a.Address);

		/// <summary>
		/// Sample Code - Ermittelt die aktuellen sichtbaren Arbeitgeber
		/// </summary>
		public IEnumerable<Address> VisibleEmployers =>
			Addresses.Where(av =>
				av.Visible
				&&
				av.AddressValidityType == AddressValidityType.Employer
				&&
				av.ValidFrom > DateTime.Now
				&&
				av.ValidTill > DateTime.Now).Select(a => a.Address);

		/// <summary>
		/// Sample Code - Ermittel den Lebendstatus der Person
		/// </summary>
		public bool IsAlive => ValidData.DateOfDeath == null || ValidData.DateOfDeath < DateTime.Now;

		/// <summary>
		/// Sample Code - Ermittelt ob alle das Eintrittsdatum als Jumi sehen dürfen.
		/// </summary>
		public bool IsMemberYoungDateVisible => IsVisibleStatus(
			StatusType.MemberYoung, StatusChangeType.Start);
		/// <summary>
		/// Sample Code - Ermittelt das Eintrittsdatum als Jumi
		/// </summary>
		public DateTime? MemberYoungDate => StatusDate(
			StatusType.MemberYoung, StatusChangeType.Start);
	}
}
