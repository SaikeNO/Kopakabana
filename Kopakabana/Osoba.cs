using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class Osoba
    {
        protected string name;
        protected string surname;

        public Osoba(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
