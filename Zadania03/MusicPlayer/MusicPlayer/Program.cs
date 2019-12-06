using System;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player player = new Player();

            {
                bool kolejny;
                int licznik = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine($"Utwory {licznik}\n");
                    Console.Write("Podaj tytuł:\t\t\t");
                    var title = Console.ReadLine();
                    Console.Write("Podaj wykonawcę:\t\t\t");
                    var artist = Console.ReadLine();

                    Song song = new Rock(title, artist);
                    player.Add(song);

                    kolejny = Helper.CzyKontynuowac("Czy dandać kolejny? [t/n]");

                } while (kolejny);

                Console.WriteLine($"\nIlość dodanych kontaktów: {licznik}\n");
            }
            
        }
    }
}