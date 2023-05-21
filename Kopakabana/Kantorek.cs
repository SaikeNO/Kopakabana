namespace Kopakabana
{
	class Kantorek
	{
		private List<Sedzia> listaSedziow = new();

		public Sedzia UsunSedziego(Sedzia sedzia)
		{
            listaSedziow.Remove(sedzia);
			return sedzia;
		}

		public void DodajSedziego(Sedzia sedzia)
		{
            listaSedziow.Add(sedzia);
		}

		public List<Sedzia> GetSedziowie()
		{
			return listaSedziow;
		}
	}
}
