using System;

namespace Kopakabana
{
	class Kantorek
	{
		private List<Sedzia> ListaSedziow = new List<Sedzia> ();

		public Sedzia UsunSedziego(Sedzia sedzia)
		{
			ListaSedziow.Remove(sedzia);
		}

		public void DodajSedziego(Sedzia sedzia)
		{
			ListaSedziow.Add(sedzia);
		}

		public List<Sedzia> GetSedziowie()
		{
			return ListaSedziow;
		}
	}
}
