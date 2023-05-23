namespace Kopakabana
{
    [Serializable()]
    class Kantorek
    {
        private List<Sedzia> listaSedziow = new();

        public Kantorek()
        { }
        public Sedzia UsunSedziego(Sedzia sedzia)
        {
            listaSedziow.Remove(sedzia);
            return sedzia;
        }

        public void DodajSedziego(Sedzia sedzia)
        {
            listaSedziow.Add(sedzia);
        }

        public List<Sedzia> GetSedziowie()
        {
            return listaSedziow;
        }
    }
}
