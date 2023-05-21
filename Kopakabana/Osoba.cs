using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class Osoba
    {
        private string name;
        private string surname;

        public Osoba(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string GetName() { return name; }
        public string GetSurname() {  return surname; }
    }
}
