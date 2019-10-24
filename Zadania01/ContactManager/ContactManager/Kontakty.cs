using System;
using System.Collections.Generic;
namespace ContactManager
{
    public class Kontakty
    {


        private List<Osoba> _kontakty = new List<Osoba>();
        private int _iloscKontaktow;

        public int IloscKontaktow
        {
            get => _iloscKontaktow;
            set => _iloscKontaktow = value;
        }

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

            for (int i = 0; i < _iloscKontaktow; i++)
            {
                Console.Clear();
                Console.WriteLine($"Dane osoby {_iloscKontaktow}\n");
                Console.Write("Podaj imię:\t\t\t");
                var imie = Console.ReadLine();
                Console.Write("Podaj Nazwisko:\t\t\t");
                var nazwisko = Console.ReadLine();


                Adres adres = DodajAdres();
                Osoba osoba = new Osoba();
                osoba.UstawDane(imie, nazwisko, adres);
                _kontakty.Add(osoba);

            }
            Console.Clear();
            Console.WriteLine($"\nIlość dodanych kontaktów: {_iloscKontaktow}\n");
            Dodatki.Czekaj();

        }
        public void PokazKontakt()
        {
            int i = 0;
            foreach (Osoba osoba in _kontakty)
            {
                i++;
                Console.WriteLine($"{i}: {osoba.PobierzDane()}");
                
            }
            Console.WriteLine();
        }
        public void PokazDaneOsoby(int numerkontaktu)
        {
            if (numerkontaktu >= _iloscKontaktow)
            {
                Console.WriteLine($"\n! Błędny numer kontaktu, ilość w bazie: {_iloscKontaktow}\n");
                return;

            }
            Console.Clear();
            Console.WriteLine("- Szczegóły kontaktu: -\n");
            Console.WriteLine(_kontakty[numerkontaktu].PobierzAdres());

        }
    }
}
