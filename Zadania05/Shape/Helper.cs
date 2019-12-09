using System;

namespace Shape
{
    public class Helper
    {

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

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Generate sample data"); Console.WriteLine("[2] Default sort"); Console.WriteLine("[3] Sort by Circut"); Console.WriteLine("[4] Filter by Shape type"); Console.WriteLine("[5] Display shapes"); Console.WriteLine("[0] Exit");
        }

        public static void Wait()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }

    }
}