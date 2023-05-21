namespace Kopakabana
{
	class Kwalifikacje
	{
		private ListaDruzyn listaDruzyn;
		private Tabela tabela;
		private Sport sport;

		public Kwalifikacje(Sport sport, ListaDruzyn listadruzyn, Kantorek kantorek)
		{
			this.sport = sport;
			this.listaDruzyn = listadruzyn;
			// dokonczyc
		}

		public void Rozegraj()
		{
			// do zrobienia
		}

		public override ListaDruzyn ZnajdzNajlepsze4()
		{
			// do zrobienia
		}

		// to niżej nie wiadomo czy git
		public override Tabela GetTabela()
		{
			return tabela;
		}
	}
}
