namespace Kopakabana
{
    class Drabinka
    {
        private Druzyna d1, d2, d3, d4;
        private Druzyna? wygranaDruzyna { get; set; }

        public Drabinka(List<Druzyna> lista)
        {
            d1 = lista[0];
            d2 = lista[1];
            d3 = lista[2];
            d4 = lista[3];
        }
        public void Rozegraj()
        { }
    }
}