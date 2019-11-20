using System;
using System.Threading;
using System.Diagnostics;
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
            Console.WriteLine("1. Podaj dane samochodu");
            Console.WriteLine("2. Zapisz dane samochodu");
            Console.WriteLine("3. Wczitaj dane samochodu");
            Console.WriteLine("-----");
            Console.WriteLine("4. Dane samochodu");
            Console.WriteLine("5. Jazda");
            Console.WriteLine("6. Tankowanie");
            Console.WriteLine("7. Wyjście");
        }
        public static void Wait()
        {
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();

        }
        public static void distanceAnim(int distance)
        {
            //Stopwatch stoper = new Stopwatch();
            //stoper.Start();
            for (int i = 1; i <= distance; i++)
            {
                Console.Write($"\rProgress: {i} km   ");
                Thread.Sleep(100);
            }
            //stoper.Stop();

            //Console.WriteLine(stoper.Elapsed);
        }


    }
}
