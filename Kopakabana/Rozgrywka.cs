

namespace Kopakabana
{
    class Rozgrywka
    {
        private Druzyna druzyna1, druzyna2;
        private Druzyna wygranaDruzyna;
        private Sedzia sedzia;
        
        public Rozgrywka(Druzyna druzyna1, Druzyna druzyna2, Sedzia sedzia)
        {
            this.druzyna1 = druzyna1;
            this.druzyna2 = druzyna2;
            this.sedzia = sedzia;
        }
        public Druzyna WygranaDruzyna { get { return wygranaDruzyna; } set { wygranaDruzyna = value; } } 
        public Sedzia Sedzia { get { return sedzia; } set { sedzia = value; } } 
        public override string ToString()
        {
            return "";
        }
        
    }
}