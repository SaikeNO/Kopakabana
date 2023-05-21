using System;

namespace Kopakabana
{
	class Druzyna
	{
		private List<Zawodnik> Zawodnicy = new ();
		private string Nazwa;

		public Druzyna(string Nazwa)
		{
			this.Nazwa = Nazwa;
		}

		public Druzyna(string Nazwa, List<Zawodnik> lista)
		{
			this.Nazwa = Nazwa;
			this.Zawodnicy.AddRange(lista);
		}

		public List<Zawodnik> GetZawodnicy()
		{
			return Zawodnicy;
		}

		public void DodajZawodnika(Zawodnik zawodnik)
		{
			List.Add(zawodnik);
		}

        public string Nazwa{ get { return Nazwa; } set { Nazwa = value; } }

    }
}
