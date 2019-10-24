using System;
using System.Collections.Generic;
namespace Zadania01
{
    public class Kontakty
    {


        private List<Osoba> _kontakt = new List<Osoba>();
        private int _iloscKontaktow;

        public int IloscKontaktow
        {
            get => _iloscKontaktow;
            set => _iloscKontaktow = value;
        }

        private Adres DodajAdres()
        {
            Console.WriteLine("--------------");
            Console.Write("Podaj ulicę: \t");
            var ulica = Console.ReadLine();
            Console.Write("Podaj Numer domu: \t");
            var numer_domu = Console.ReadLine();
            Console.Write("Podaj Numer mieszkania: t");
            var numer_mieszkania = Console.ReadLine();
            Console.Write("Podaj kod pocztowy: \t");
            var kod_pocztowy = Console.ReadLine();
            Console.Write("Podaj miasto: \t");
            var miasto = Console.ReadLine();
            Console.Write("Podaj Państwo: \t");
            var panstwo = Console.ReadLine();

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
                Console.Write("Podaj imię:\t");
                var imie = Console.ReadLine();
                Console.Write("Podaj Nazwisko:\t");
                var nazwisko = Console.ReadLine();


                Adres adres = DodajAdres();
                Osoba osoba = new Osoba();
                osoba.UstawDane(imie, nazwisko, adres);
                _kontakt.Add(osoba);
                
            }

            Console.WriteLine($"Ilość dodanych kontaktów: {_iloscKontaktow}");
            //Console.WriteLine();
            //osoba.PobierzDane();



            //Console.WriteLine();
            //osoba.PobierzAdres();
            //Console.WriteLine();


            // osoba.UstawDane(imie, nazwisko);

        }
        public void PokazKontakt()
        {
            int i = 0;
            foreach (Osoba osoba in _kontakt)
            {
                i++;
                Console.WriteLine($"{i}: {osoba.PobierzDane()}");
                

            }
        }
    }
}
