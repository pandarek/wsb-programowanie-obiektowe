using System;
namespace MusicPlayer
{
    public class Helper
    {
        public static bool CzyKontynuowac(string pytanie)
        {

            bool keyisok = false;

            Console.WriteLine($"{pytanie}\r");

            while (!keyisok)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.KeyChar == 't') return true;
                if (key.KeyChar == 'n') return false;
                keyisok &= (key.KeyChar == 'n' && key.KeyChar == 't');
            }
            return false;
        }

        public static int PodajLiczbe(string wiadomosc)
        {
            bool udalosoe = false;
            int result = 0;

            while ((!udalosoe) || (result < 1))
            {
                Console.Write(wiadomosc);
                udalosoe = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        public static void Menu()
        {
            Console.WriteLine("\n1. Rock, 2. Hard Core, 3. Electro\n");
        }

        public static void Czekaj()
        {
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();
        }

        public static void PlayAnim()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);

            }
            Console.WriteLine();
        }
    }
}   