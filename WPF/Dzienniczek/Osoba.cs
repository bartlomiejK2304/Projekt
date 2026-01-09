using System;
using System.Collections.Generic;
using System.Text;

namespace Dzienniczek
{
    public abstract class Osoba
    {
        public string Imie { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;

        private string _pesel = string.Empty;
        public string Pesel
        {
            get => _pesel;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                {
                    _pesel = value;
                }
                else
                {
                    throw new ArgumentException("Pesel must be exactly 11 characters.", nameof(Pesel));
                }
            }
        }

        public virtual void WypiszInfo() { }

    }
}
