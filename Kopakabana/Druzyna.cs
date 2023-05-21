using System;

namespace Kopakabana
{
	class Druzyna
	{
		private List<Zawodnik> zawodnicy = new();
		private string nazwa;

		public Druzyna(string Nazwa)
		{
			nazwa = Nazwa;
		}

		public Druzyna(string Nazwa, List<Zawodnik> lista)
		{
			nazwa = Nazwa;
			zawodnicy.AddRange(lista);
		}

		public List<Zawodnik> GetZawodnicy()
		{
			return zawodnicy;
		}

		public void DodajZawodnika(Zawodnik zawodnik)
		{
            zawodnicy.Add(zawodnik);
		}

        public string Nazwa{ get { return nazwa; } set { nazwa = value; } }

    }
}
