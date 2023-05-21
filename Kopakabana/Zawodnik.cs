namespace Kopakabana
{
	class Zawodnik : Osoba
	{
		private int numerKoszulki;

		public Zawodnik(string name, string surname, int numerKoszulki) : base(name, surname)
		{
			this.numerKoszulki = numerKoszulki;
		}

		public int GetNumerKoszulki() 
		{ 
			return numerKoszulki;
		}
	}
}
