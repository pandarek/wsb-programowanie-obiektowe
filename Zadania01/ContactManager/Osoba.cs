using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ContactManager
{
    [Serializable]
    public class Osoba : IComparable<Osoba>
    {
        private string _imie;
        private string _nazwisko;
        private Adres _adres;
        private int _wiek;


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

        public int Wiek { get => _wiek; set => _wiek = value; }

        public string PobierzDane()
        {
            return $"{_imie} {_nazwisko} {_wiek}";

        }
        public string PobierzAdres()
        {
            return $"Nazywa się {_imie} {_nazwisko}\nAdress: {_adres}\n";

        }
        public void UstawDane(string imie, string nazwisko, int wiek, Adres adres)
        {
            this._imie = imie;
            this._nazwisko = nazwisko;
            this._adres = adres;
            this._wiek = wiek;
        }

        public int CompareTo(Osoba other)
        {
            return Imie.CompareTo(other.Imie);
        }
    }
    class CompareByNazwisko : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            if (x == null || y == null) return 0;
            return x.Nazisko.CompareTo(y.Nazisko);
        }
    }
    class CompareByImie : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            if (x == null || y == null) return 0;
            return x.Imie.CompareTo(y.Imie);
        }
    }
    class CompareByWiek : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            if (x == null || y == null) return 0;
            return x.Wiek.CompareTo(y.Wiek);
        }
    }
}