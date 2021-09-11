namespace AVAVLib
{
	/// <summary>
	/// Mögliche Statusänderungen im AV
	///
	/// Offene Punkte:
	///
	/// Ist eine Unterscheidung ADAH und Student im AVeV nötig?
	/// Gibt es Fördermitglieder nur in der HG?
	/// Was ist der Ex-Aktive? Reicht dazu das Ende des Aktivenstatus?
	/// </summary>
	public enum StatusType
	{
		/// <summary>
		/// Aufnahme eines Studium in einem Studiengang
		/// </summary>
		FieldOfStudy,
		/// <summary>
		/// Verkehrsgast
		/// </summary>
		MemberVerkehrsgast,
		/// <summary>
		/// JuMi
		/// </summary>
		MemberYoung,
		/// <summary>
		/// VoMi
		/// </summary>
		MemberAktivitas,
		/// <summary>
		/// Studentisches Mitglied im AVeV
		/// </summary>
		MemberAvStudent,
		/// <summary>
		/// Mitglied im AVeV 
		/// </summary>
		MemberAvFull,		
		/// <summary>
		/// Studentisches Mitglied in der HG
		/// </summary>
		MemberHgStudent,
		/// <summary>
		/// Mitglied der HG
		/// </summary>
		MemberHgFull,
		/// <summary>
		/// Anteilsscheine gekauft
		/// </summary>
		MemberHgShares,
		/// <summary>
		/// Beisitzer im Vorstand der HG
		/// </summary>
		MemberHgSustaining, 
		/// <summary>
		/// Mitglied der GAV
		/// </summary>
		MemberGav,
		/// <summary>
		/// Ehrenmitglied
		/// </summary>
		MemberHonorary,
		/// <summary>
		/// Als StuGi aufs Haus gezogen
		/// </summary>
		StuGi,
		/// <summary>
		/// 1x der Aktivitas
		/// </summary>
		Active1X,
		/// <summary>
		/// 2x der Aktivitas
		/// </summary>
		Acitve2X,
		/// <summary>
		/// 3x der Aktivitas
		/// </summary>
		Active3X,
		/// <summary>
		/// Kassenwart der Aktivitas
		/// </summary>
		ActiveKw,
		/// <summary>
		/// 1x AV e.V.
		/// </summary>
		Adah1X,
		/// <summary>
		/// 2x AV e.V.
		/// </summary>
		Adah2X,
		/// <summary>
		/// Schriftführer AV e.V.
		/// </summary>
		AdahSw,
		/// <summary>
		/// Kassenwart AV e.V.
		/// </summary>
		AdahKw,
		/// <summary>
		/// Beisitzer im Vorstand AV e.V.
		/// </summary>
		AdahAssoc,
		/// <summary>
		/// Chronist
		/// </summary>
		Chronicler,
		/// <summary>
		/// Alte Dame, Alter Herr
		/// </summary>
		Adah,
		/// <summary>
		/// 1. Vorsitzender Hausgesellschaft AV e.V.
		/// </summary>
		Hg1X,
		/// <summary>
		/// 2. Vorsitzender Hausgesellschaft AV e.V.
		/// </summary>
		Hg2X,
		/// <summary>
		/// Kassenwart Hausgesellschaft AV e.V.
		/// </summary>
		HgKw,
		/// <summary>
		/// Studentisches Mitglied im Vorstand der Hausgesellschaft AV e.V.
		/// </summary>
		HgStud,
		/// <summary>
		/// Beisitzer im Vorstand der Hausgesellschaft AV e.V.
		/// </summary>
		HgAssoc,
		/// <summary>
		/// 1. Vorsitzender GAV
		/// </summary>
		Gav1X,
		/// <summary>
		/// Hauswart der GAV
		/// </summary>
		GavHw,
		/// <summary>
		/// Kassenwart der GAV
		/// </summary>
		GavKw,
		/// <summary>
		/// Beisitzer im Vorstand der GAV
		/// </summary>
		GavAssoc
	}
}