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

        public Druzyna Druzyna { 
            get 
            { 
                return druzyna; 
            } 
        }

        public void dodajPunkt()
        {
            punkty++;
        }

        public int getPunkty()
        {
            return punkty;
        }

    }
}
