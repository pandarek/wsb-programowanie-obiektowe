using System;

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Kontakty kontakty = new Kontakty();


            Console.WriteLine("\n- Książka Adresowa -\n");

            kontakty.IloscKontaktow = Dodatki.PodajLiczbe("Podaj lość osób do wprowadzenia: ");

            kontakty.DodajKontakt();

            bool wyjscie = false;

            while (!wyjscie)
            {

                Dodatki.Menu();

                switch (Dodatki.PodajLiczbe("Wybierz: "))
                {
                    case 1:
                        Console.WriteLine();
                        kontakty.PokazKontakt();
                        Dodatki.Czekaj();
                        break;
                    case 2:
                        int numerkontaktu = Dodatki.PodajLiczbe("Podaj numer osoby do wyświetlenia: ");
                        kontakty.PokazDaneOsoby(numerkontaktu - 1);
                        Dodatki.Czekaj();
                        break;
                    case 3:
                        wyjscie = true;
                        break;
                }

            }
        }
    }
}
