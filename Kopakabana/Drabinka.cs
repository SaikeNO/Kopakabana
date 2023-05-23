namespace Kopakabana
{
    class Drabinka
    {
        private Kantorek Kantorek;
        private Druzyna d1, d2, d3, d4;
        private Sport Sport { get; set; }
        public Druzyna? wygranaDruzyna { get; set; }
        public Drabinka(Sport sport, List<Druzyna> lista, Kantorek kantorek)
        {
            d1 = lista[0];
            d2 = lista[1];
            d3 = lista[2];
            d4 = lista[3];
            Kantorek = kantorek;
            Sport = sport;
        }

        public void Rozegraj()
        {
            Rozgrywka polfinal1, polfinal2, final;
            Console.WriteLine(Rozgrywka.WyswietlDruzyny(d1, d2));
            Console.WriteLine(Kantorek);

            Sedzia sedzia;

            if (Sport is Siatkowka)
            {
                sedzia = Kantorek.WybierzSedziego(Kantorek);
                Sedzia[] sedziowiePomocniczy = Kantorek.WybierzSedziowPomocniczych(Kantorek, sedzia);
                polfinal1 = new RozgrywkaSiatkowka(d1, d2, sedzia, sedziowiePomocniczy[0], sedziowiePomocniczy[1]);

                sedzia = Kantorek.WybierzSedziego(Kantorek);
                sedziowiePomocniczy = Kantorek.WybierzSedziowPomocniczych(Kantorek, sedzia);
                polfinal2 = new RozgrywkaSiatkowka(d3, d4, sedzia, sedziowiePomocniczy[0], sedziowiePomocniczy[1]);
            }
            else
            {
                sedzia = Kantorek.WybierzSedziego(Kantorek);
                polfinal1 = new Rozgrywka(d1, d2, sedzia);

                sedzia = Kantorek.WybierzSedziego(Kantorek);
                polfinal2 = new Rozgrywka(d3, d4, sedzia);
            }

            polfinal1.Rozegraj();
            polfinal2.Rozegraj();

            if(Sport is Siatkowka)
            {
                sedzia = Kantorek.WybierzSedziego(Kantorek);
                Sedzia[] sedziowiePomocniczy = Kantorek.WybierzSedziowPomocniczych(Kantorek, sedzia);
                final = new RozgrywkaSiatkowka(polfinal1.WygranaDruzyna, polfinal2.WygranaDruzyna, sedzia, sedziowiePomocniczy[0], sedziowiePomocniczy[1]);

               
            }
            else
            {
                sedzia = Kantorek.WybierzSedziego(Kantorek);
                final = new Rozgrywka(polfinal1.WygranaDruzyna, polfinal2.WygranaDruzyna, sedzia);

            }

            final.Rozegraj();
        }
    }
}