using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace ContactManager
{
    [Serializable]
    [XmlRoot("Kontakty")]
    public class Kontakty
    {

        private List<Osoba> _kontakty = new List<Osoba>();

        public int IloscKontaktow { get; set; }

        public List<Osoba> KontaktyLista { get => _kontakty; set => _kontakty = value; }



        private Adres DodajAdres()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Podaj ulicę: \t\t\t");
            var ulica = Console.ReadLine();
            Console.Write("Podaj Numer domu: \t\t");
            var numer_domu = Console.ReadLine();
            Console.Write("Podaj Numer mieszkania: \t");
            var numer_mieszkania = Console.ReadLine();
            Console.Write("Podaj kod pocztowy: \t\t");
            var kod_pocztowy = Console.ReadLine();
            Console.Write("Podaj miasto: \t\t\t");
            var miasto = Console.ReadLine();
            Console.Write("Podaj Państwo: \t\t\t");
            var panstwo = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            Adres adres = new Adres();
            adres.UstawAders(ulica, numer_domu, numer_mieszkania, kod_pocztowy, miasto, panstwo);

            return adres;
        }

        public void DodajKontakt()
        {
            bool kolejny;
            int licznik = 0;

            do
            {
                licznik++;
                Console.Clear();
                Console.WriteLine($"Dane osoby {licznik}\n");
                Console.Write("Podaj imię:\t\t\t");
                var imie = Console.ReadLine();
                Console.Write("Podaj Nazwisko:\t\t\t");
                var nazwisko = Console.ReadLine();
                var wiek = Dodatki.PodajLiczbe("Podaj wiek:\t\t\t");
                Adres adres = DodajAdres();
                Osoba osoba = new Osoba();
                osoba.UstawDane(imie, nazwisko, wiek, adres);
                _kontakty.Add(osoba);
                kolejny = Dodatki.CzyKontynuowac("Czy dandać kolejny? [t/n]");

            } while (kolejny);

           Console.WriteLine($"\nIlość dodanych kontaktów: {licznik}\n");

        }
        public void PokazKontakty()
        {
            if (_kontakty.Count == 0)
            {
                Console.WriteLine("Brak kontaktów w bazie");
                return;

            }
            int i = 0;
            foreach (Osoba osoba in _kontakty)
            {
                i++;
                Console.WriteLine($"{i}: {osoba.PobierzDane()}");

            }
            Console.WriteLine();
        }

        public void PokazDaneOsoby()
        {
            int numerkontaktu;

            if (_kontakty.Count != 0)
            {
                numerkontaktu = Dodatki.PodajLiczbe("Podaj numer osoby do wyświetlenia: ");
                Console.Clear();
                Console.WriteLine("- Szczegóły kontaktu: -\n");
                Console.WriteLine(_kontakty[numerkontaktu].PobierzAdres());
            }

        }
        public void SostowanieNazwisko()
        {
            _kontakty.Sort(new CompareByNazwisko());
        }

    }
}
