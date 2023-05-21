namespace Kopakabana
{
	class Kwalifikacje
	{
		private ListaDruzyn listaDruzyn;
		private Tabela tabela;
		private Sport sport;

		public Kwalifikacje(Sport sport, ListaDruzyn listaDruzyn)
		{
			this.sport = sport;
			this.listaDruzyn = listaDruzyn;
			tabela = new Tabela(listaDruzyn);
		}

		public void Rozegraj()
		{
			// do zrobienia z wykorzystaniem klasy Rozgrywka
		}

		public List<Druzyna> ZnajdzNajlepsze4()
		{
			return tabela.ZnajdzNajlepsze4();
		}

		public Tabela Tabela { get { return tabela; } }
        public ListaDruzyn ListaDruzyn { get { return listaDruzyn; } }
    }
}
