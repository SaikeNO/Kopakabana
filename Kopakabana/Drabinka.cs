

namespace Kopakabana
{
    class Drabinka
    {
        private Druzyna d1, d2, d3, d4;
        private Druzyna wygranaDruzyna;

        public Drabinka(List<Druzyna> lista)
        {
            this.d1 = lista[0];
            this.d2 = lista[1];
            this.d3 = lista[2];
            this.d4 = lista[3];
        }
        public void Rozegraj()
        { }

        public Druzyna WygranaDruzyna { get { return wygranaDruzyna; } set { wygranaDruzyna = value; } }
    }
}