using System;
using System.Collections.Generic;

namespace Shape
{
    public class Helper
    {

        public static int PodajLiczbe(string wiadomosc)
        {

            bool udalosoe = false;
            int result = 0;



            while ((!udalosoe) || (result < 0))
            {
                Console.Write(wiadomosc);
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            }
            return result;
        }
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Generate sample data"); Console.WriteLine("[2] Default sort"); Console.WriteLine("[3] Sort by Circut"); Console.WriteLine("[4] Filter by Shape type"); Console.WriteLine("[5] Display shapes"); Console.WriteLine("[0] Exit");
        }
        public static void Czekaj()
        {
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();

        }


    }
}
