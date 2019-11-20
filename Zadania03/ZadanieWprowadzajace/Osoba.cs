using System;
namespace ZadanieWprowadzajace
{
    public class Osoba
    {
        private string _imie;
        private string _nazwisko;

        
        public Osoba(string Imie, string Nazwisko)
        {
            this._imie = Imie;
            this._nazwisko = Nazwisko;
        }

        //public string Imie { get; set; }
        //public string Nazwisko { get; set; }

        override public string ToString()
        {
            return $"Imie: {_imie}, Nazwisko: {_nazwisko}";
        }

    }
}