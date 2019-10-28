using System;
namespace Cars
{
    public class Helper
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

        public static double PodajLiczbeDouble(string wiadomosc)
        {

            bool udalosoe = false;
            double result = 0;
            while (!udalosoe)
            {
                Console.Write(wiadomosc);
                udalosoe = double.TryParse(Console.ReadLine(), out result);

            }
            return result;
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("- Menu -\n");
            Console.WriteLine("1. Dane samochodu");
            Console.WriteLine("2. Jazda");
            Console.WriteLine("3. Tankowanie");
            Console.WriteLine("4. Wyjście");
        }
        public static void Wait()
        {
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();

        }


    }
}
