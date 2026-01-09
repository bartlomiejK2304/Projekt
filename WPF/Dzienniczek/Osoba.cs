using System;
using System.Collections.Generic;
using System.Text;

namespace Dzienniczek
{
    public abstract class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel 
        { 
            get;

            set
            {
                if (value.Length == 11)
                    Pesel = value;
            } 
        }

    }
}
