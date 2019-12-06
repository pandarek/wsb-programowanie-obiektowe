using System;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song;
            Player player = new Player();

            {
                bool kolejny;
                int licznik = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine($"Utwory {licznik}\n");
                    Console.Write("Podaj wykonawcę:\t");
                    var artist = Console.ReadLine();
                    Console.Write("Podaj tytuł:\t\t");
                    var title = Console.ReadLine();
                    
                    Helper.Menu();
                    switch (Helper.PodajLiczbe("Wybierz gatunek muzyki: "))
                    {
                        case 1:
                            song = new Rock(title, artist);
                            player.Add(song);
                            break;

                        case 2:
                            song = new HardCore(title, artist);
                            player.Add(song);
                            break;

                        case 3:
                            song = new Electro(title, artist);
                            player.Add(song);
                            break;

                        default:
                            break;
                    }
                    licznik++;                    

                    kolejny = Helper.CzyKontynuowac("Czy dandać kolejny? [t/n]");

                } while (kolejny);

                Console.WriteLine($"\nIlość dodanych utworów: {licznik}\n");


                for (int i = 0; i < player.playlist.Count; i++)
                {
                    player.Play(i);
                    player.Remove(i);

                }
            }
        }
    }
}