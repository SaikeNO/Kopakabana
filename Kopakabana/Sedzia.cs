namespace Kopakabana
{
	class Sedzia : Osoba
	{
		private Sport Sport { get; }
		public bool czyZajety { get; set; }

		public Sedzia(string name, string surname, Sport sport) : base(name, surname)
		{
			this.sport = sport;
		}

		public Sport GetSport()
		{
			return sport;
		}
	}
}
