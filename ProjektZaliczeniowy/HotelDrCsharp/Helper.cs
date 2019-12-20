using System;
namespace HotelDrCsharp
{
    public class Helper
    {
        public static void MainMenu() {

            Console.Title = "DrCsharp - System Rezerwacji Hotelowej"; //nazwa konsoli

            Console.Clear();
            Console.WriteLine("\nSystem rezerwacji HotelDrCsharp\n");
            Console.WriteLine("Wybierz opcje: ");

            Console.WriteLine("1 - Dodaj rezerwacje");
            Console.WriteLine("2 - Usun rezerwacje");
            Console.WriteLine("3 - Sprawdz miejsce");
            Console.WriteLine("4 - Wyswietl wszystkie pokoje");
            Console.WriteLine("5 - Wyswietl wolne miejsca");
            Console.WriteLine("6 - Wyswietl zarezerwowane pokoje");
            Console.WriteLine("7 - Zamknij system");
        }
        public static int InputInt(string msg)
        {

            bool udalosoe = false;
            int result = 0;

            while ((!udalosoe) || (result < 0))
            {
                Console.Write(msg);
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            }
            return result;
        }

        public static void Wait()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }

    }
}