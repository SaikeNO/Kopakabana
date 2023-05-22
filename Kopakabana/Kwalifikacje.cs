namespace Kopakabana
{
	class Kwalifikacje
	{
		private Tabela Tabela { get; set; }
		private Sport sport;
		private List<Rozgrywka> listaRozgrywek = new();

		public Kwalifikacje(Sport sport, List<Druzyna> listaDruzyn)
		{
			this.sport = sport;
            Tabela = new Tabela(listaDruzyn, sport);

			for (int i = 0; i < listaDruzyn.Count; i+=2)
			{
				listaRozgrywek.Add(new Rozgrywka(listaDruzyn[i], listaDruzyn[i + 1])); 
				// Problem z sedziami
				// Dwie możliwości: przekazujemy tu liste wszystkich sedziow
				// i na podstawie sportu sedziego jest przypisywany do klasy Rozgrywka
				// albo w konstrutorze Rozgrywka wymusić na użytkowniku wybór sędziego do danej Rozgrywki
			}
		}

		public void Rozegraj()
		{
			// do zrobienia z wykorzystaniem klasy Rozgrywka
		}

		public List<Druzyna> ZnajdzNajlepsze4()
		{
			return Tabela.ZnajdzNajlepsze4();
		}
    }
}
