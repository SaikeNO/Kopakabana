namespace Kopakabana
{
    class Tabela
    {
        private List<WierszTabeli> wiersze = new();
        private Sport sport;
        private ListaDruzyn listaDruzyn;

        public Tabela(List<Druzyna> listaDruzyn, Sport sport)
        {
            this.sport = sport;

            foreach(Druzyna druzyna in listaDruzyn)
            {
                wiersze.Add(new WierszTabeli(druzyna));
            }
        }

        public Tabela(ListaDruzyn listaDruzyn)
        {
            this.listaDruzyn = listaDruzyn;
        }

        public void DodajPunkt(Druzyna druzyna)
        {
            foreach(WierszTabeli wiersz in wiersze)
            {
                if (druzyna == wiersz.Druzyna) wiersz.DodajPunkt();
            }
        }

        public void Sortuj()
        {
            wiersze.Sort((a, b) => b.GetPunkty().CompareTo(a.GetPunkty()));
        }
        public List<Druzyna> ZnajdzNajlepsze4()
        {
            List<Druzyna> druzyny = new();

            for (int i = 0; i < 4; i++)
            {
                druzyny.Add(wiersze[i].Druzyna);
            }

            return druzyny;
        }

        public List<WierszTabeli> GetTabela()
        {
            return wiersze;
        }

        public Sport Sport { get { return sport; } }
    }
}
