using System;
using System.Security;
using System.Text;

namespace HotelDrCsharp
{
    public class Helper
    {
        public static void MainMenu() {

            Console.Title = "DrCsharp - System Rezerwacji Hotelowej"; //nazwa konsoli
            Console.BackgroundColor = ConsoleColor.Black; //kolor tła konsoli
            Console.ForegroundColor = ConsoleColor.Green; //kolor pierwszego planu konsoli

            Console.Clear();
            Console.WriteLine("System rezerwacji HotelDrCsharp\n");
            Console.WriteLine("Login: " + Program.currentuser.Login);
            Console.WriteLine("Czy admin: " + Program.currentuser.IsAdminn());
            Console.WriteLine("Wybierz opcje: ");

            Console.WriteLine("1 - Dodaj rezerwacje");
            Console.WriteLine("2 - Usun rezerwacje");
            Console.WriteLine("3 - Sprawdz miejsce");
            Console.WriteLine("4 - Wyswietl wszystkie pokoje");
            Console.WriteLine("5 - Wyswietl wolne miejsca");
            Console.WriteLine("6 - Wyswietl zarezerwowane pokoje");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("9 - Ustawienia");
            Console.WriteLine("0 - Zamknij system");
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

        public static int InputIntRange(string msg, int from, int to)
        {

            bool udalosoe;
            int result;

            do
            {
                Console.Write(msg);
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            } while ((!udalosoe) && (result >= from) && (result <= to));

            return result;
        }

        
        public static void Wait()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }


        public static string GetConsolePassword()
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        Console.Write("\b\0\b");
                        sb.Length--;
                    }

                    continue;
                }

                Console.Write('*');
                sb.Append(cki.KeyChar);
            }

            return sb.ToString();
        }

    }
}