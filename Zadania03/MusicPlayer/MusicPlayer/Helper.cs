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
    }
}
