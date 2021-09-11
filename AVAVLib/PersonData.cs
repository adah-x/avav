using System;
using System.Collections.Generic;
using System.Text;

namespace AVAVLib
{
	/// <summary>
	/// Version eines Datensatzes zu einer Person, bei Änderungen werden immer neue Versionen erstellt,
	/// der laut Zeitstempel letzte gültige (valid) Datensatz ist der aktuelle Stand.
	/// Mitglieder können schwebende Datensätze anlegen, bei diesen ist dann valid=false
	/// </summary>
    public partial class PersonData
	{
		/// <summary>
		/// Zeigt an, ob der Datensatz schwebt oder schon von einem Schriftwart übernommen wurde.
		/// </summary>
		public bool Valid { get; set; }
		/// <summary>
		/// Zeitpunkt der Erstellung
		/// </summary>
		public DateTime TimeStamp { get; set; } = DateTime.Now;
		/// <summary>
		/// Only one handle, since changes are stored in new Person Records 
		/// </summary>
		public ChangeHandle ChangeHandle { get; set; }
		/// <summary>
		/// Person zu der die Datensatzversion gehört
		/// </summary>
		public Person Person { get; set; }
		/// <summary>
		/// Geschlechtliche Identität
		/// </summary>
		public Gender Gender { get; set; }
		/// <summary>
		/// Akademische Grade, die vor den Namen gestellt werden.
		/// </summary>
		public string PrefixTitle { get; set; }
		/// <summary>
		/// Akademische Grade, die hinter den Namen gestellt werden.
		/// </summary>
	    public string SuffixTitle { get; set; }
		/// <summary>
		/// Staatsexamen oder sonstige Berufsabschlüsse. Die Lehrer legen da Wert drauf,
		/// denn die bekommen kein Diplom und sind dann irgendwann Studienrat oder so was.
		/// </summary>
		public string StaatsexamenProfession { get; set; }
		/// <summary>
		/// Präfix für einen Vornamen, z.B. De Witt, würde nach Witt einsortiert, weil De ein Präfix ist.
		/// </summary>
		public string GivenNamePrefix { get; set; }
		/// <summary>
		/// Erster Vorname
		/// </summary>
	    public string GivenName { get; set; }
		/// <summary>
		/// Weitere Vornamen
		/// </summary>
	    public string AdditionalNames { get; set; }
		/// <summary>
		/// Präfix zum Familiennamen, z.B. von --> Sortierung
		/// </summary>
	    public string NamePrefix { get; set; }
		/// <summary>
		/// Familienname
		/// </summary>
	    public string Name { get; set; }
		/// <summary>
		/// Anhang zum Familiennamen, z.B. sen., jun., III.
		/// </summary>
	    public string NameSuffix { get; set; }
		/// <summary>
		/// Geburtsname
		/// </summary>
	    public string MaidenName { get; set; }
		/// <summary>
		/// Biername
		/// </summary>
	    public string Nickname { get; set; } = null;
		/// <summary>
		/// Sollen alle Bundesgeschwister die offizielle EMail-Addresse sehen?
		/// </summary>
	    public bool? IsEMailOfficialVisible { get; set; }
		/// <summary>
		/// Offizielle EMail-Address, z.B. zur Verwendung bei Einladungen zur MV
		/// </summary>
	    public string EMailOfficial { get; set; }
		/// <summary>
		/// Sollen alle Bundesgeschwister die zusätzliche EMail-Addresse sehen?
		/// </summary>
	    public bool? IsEMailStuffVisible { get; set; }
		/// <summary>
		/// EMail-Adresse für Verteiler.
		/// </summary>
	    public string EMailStuff { get; set; }
		/// <summary>
		/// Sollen alle Bundesgeschwister meinen Geburtstag sehen?
		/// </summary>
		public bool IsBirthdayVisible { get; set; } = false;
		/// <summary>
		/// Geburtstag
		/// </summary>
	    public DateTime? Birthday { get; set; } = null;
		/// <summary>
		/// Todestage --> Ist Nullable, d.h. IsAlive oder Kenner für Verstorben sollten immer
		/// aus diesem Datum abgeleitet werden.
		/// </summary>
	    public DateTime? DateOfDeath { get; set; } = null;

		/// <summary>
		/// Sollen alle Bundesgeschwister meinen Geburtsort sehen können?
		/// </summary>
		public bool? IsBirthPlaceVisible { get; set; }
		/// <summary>
		/// Geburtsort
		/// </summary>
	    public string BirthPlace { get; set; }
		/// <summary>
		/// Sollen alle Bundesgeschwister meine AV-Kolonie sehen?
		/// </summary>
		public bool? IsAvColonyVisible { get; set; }
		/// <summary>
		/// AV-Kolonie
		/// </summary>
	    public string AvColony { get; set; } // TODO --> Liste im Frontend
		/// <summary>
		/// Sollen alle Bundesgeschwister meine offizielle Mobil-Telefonummer sehen?
		/// </summary>
		public bool IsMobilTelOffcialVisible { get; set; } = false;
		/// <summary>
		/// Offzielle Mobil-Telefonnummer
		/// </summary>
	    public string MobilTelOfficial { get; set; }
		/// <summary>
		/// Sollen alle Bundesgeschwister meine 1. zusätzliche Mobil-Telefonummer sehen?
		/// </summary>
		public bool IsMobilTelAdd1Visible { get; set; } = false;
		/// <summary>
		/// 1. zusätzliche Mobilfunknummer
		/// </summary>
	    public string MobilTelAdd1 { get; set; }
		/// <summary>
		/// Sollen alle Bundesgeschwister meine 2. zusätzliche Mobil-Telefonummer sehen?
		/// </summary>
		public bool IsMobilTelAdd2Visible { get; set; } = false;
		/// <summary>
		/// 2. zusätzliche Mobilfunknummer
		/// </summary>
		public string MobilTelAdd2 { get; set; }
		/// <summary>
		/// Sollen alle Bundesgeschwister meine web-Site sehen?
		/// </summary>
		public bool IsWebSiteVisible { get; set; } = false;
		/// <summary>
		/// Web-Site
		/// </summary>
	    public string WebSite { get; set; }
		/// <summary>
		/// Zuständigkeit (Verwaltung des Datensatzes)
		/// </summary>
	    public Authority Authority { get; set; }
		/// <summary>
		/// Debitorennummer -- sollten wir eigentlich rauswerfen und nur noch die AVID verwenden.
		/// </summary>
	    public long? DebitNummer { get; set; }
	}
}
