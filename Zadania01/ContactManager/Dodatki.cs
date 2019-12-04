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
            
            Console.WriteLine("1. Dodaj kontakty");
            Console.WriteLine("2. Pokaż wszystkie kontakty");
            Console.WriteLine("3. Pokaż szczegóły kontaktu");
            Console.WriteLine("4. Sortuj kontakty");
            Console.WriteLine("5. Zapisz dane");
            Console.WriteLine("6. Wczytaj Dane");
            Console.WriteLine("9. Wyjście\n");
        }
        public static void Czekaj()
        {
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();
           
        }
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
