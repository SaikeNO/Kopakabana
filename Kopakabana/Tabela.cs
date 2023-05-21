namespace Kopakabana
{
    class Tabela
    {
        private List<WierszTabeli> wiersze = new();
        private Sport sport;

        public Tabela(List<Druzyna> listaDruzyn, Sport sport) 
        {
            this.sport = sport;
        }

        public void DodajPunkt(Druzyna druzyna)
        {
            foreach(WierszTabeli wiersz in wiersze)
            {
                if (druzyna == wiersz.Druzyna) wiersz.dodajPunkt();
            }
        }

        public void Sortuj()
        {

        }
        public List<Druzyna> ZnajdzNajlepsze4()
        {
            List<Druzyna> druzyna = new();

            for (int i = 0; i < 4; i++)
            {
                druzyna.Add(wiersze[i].Druzyna);
            }

            return druzyna;
        }

        public List<WierszTabeli> GetTabela()
        {
            return wiersze;
        }

        public Sport Sport { get { return sport; } }
    }
}
