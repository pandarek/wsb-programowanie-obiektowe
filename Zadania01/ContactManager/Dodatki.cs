using System;
namespace ContactManager
{
    public static class Dodatki
    {
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
            Console.Clear();
            Console.WriteLine("- Książka Adresowa Menu -\n");
            Console.WriteLine("1. Pokaż wszystkie kontakty");
            Console.WriteLine("2. Pokaż szczegóły kontaktu");
            Console.WriteLine("3. Wyjście\n");
        }
        public static void Czekaj()
        {
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();
           
        }
    }
}
