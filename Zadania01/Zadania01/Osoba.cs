using System;
namespace Zadania01
{
    public class Osoba
    {
        private string _imie;
        private string _nazwisko;
        private Adres _adres;
        
        //public Osoba(string imie, string nazwisko, Adres adres)
        //{
        //    this._imie = imie;
        //    this._nazwisko = nazwisko;
        //    this._adres = adres;
        //}

        public string Imie
        {
            get => _imie;
            
            set => _imie = value;
            

        }
        public string Nazisko
        {
            get => _nazwisko;
            
            set => _nazwisko = value;
            
        }
        public Adres Adres
        {
            get => _adres;
            set => _adres = value;
        }


        public string PobierzDane()
        {
            return $"{_imie} {_nazwisko}";

        }
        public void PobierzAdres()
        {
            //Console.WriteLine("Nazywam się {0} {1}\nAdress:", _imie, _nazwisko, _adres);
            Console.WriteLine($"Nazywam się {_imie} {_nazwisko}\nAdress: {_adres}");

        }
        public void UstawDane(string imie, string nazwisko, Adres adres)
        {
            this._imie = imie;
            this._nazwisko = nazwisko;
            this._adres = adres;
        }

    }
}
