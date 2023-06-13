using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { private get; set; }

        public string ShowFullName()
        {
            return string.Format("{0} {1}, wiek {2}", Imie, Nazwisko, Wiek);
        }
    }
}
