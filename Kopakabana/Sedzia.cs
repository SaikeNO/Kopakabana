using System;

namespace Kopakabana
{
	class Sedzia : Osoba
	{
		private Sport sport;

		public override Sport(string name, string surname,Sport sport) : base(name, surname)
		{
			this.sport = sport;
		}

		public Sport GetSport()
		{
			return sport;
		}
	}
}
