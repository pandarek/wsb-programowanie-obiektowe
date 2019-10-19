using System;

namespace Zadania01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //osoba.PrzedstawSie();
            //osoba.UstawDane("Jan","Kowalski");

            //Console.WriteLine();

            //osoba.PrzedstawSie();

            //Console.WriteLine();

            //Osoba osoba2 = osoba;

            //osoba2.Imie = "Adam";
            //osoba2.Nazisko = "Nowak";

            //osoba2.PrzedstawSie();


          //  Osoba osoba = new Osoba();

            

            Kontakty kontakty = new Kontakty();

            

            bool udalosoe = false;
            int result = 0;
            while ((!udalosoe) || (result < 1))
            {
                Console.Clear();
                Console.WriteLine("Podaj ilość kontaktów:");
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            }
            kontakty.IloscKontaktow = result;

          


            kontakty.DodajKontakt();

            kontakty.PokazKontakt();


            


        }
    }
}
