using System;

namespace Kopakabana
{
	class Zawodnik : Osoba
	{
		private int NumerKoszulki;

		public Zawodnik(string name, string surname, int numerkoszulki) : base(name, surname)
		{
			NumerKoszulki = numerkoszulki;
		}

		public int GetNumerKoszulki() 
		{ 
			return NumerKoszulki;
		}
	}
}
