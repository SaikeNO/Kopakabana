namespace Kopakabana
{
    class WierszTabeli 
    {
        private int punkty;
        private Druzyna druzyna;

        public WierszTabeli(Druzyna druzyna)
        {
            punkty = 0;
            this.druzyna = druzyna;
        }

        public void DodajPunkt() { punkty++; }
        public int GetPunkty() { return punkty; }

        public Druzyna Druzyna { get { return druzyna; } }
    }
}
