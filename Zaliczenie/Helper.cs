using System;
namespace Zaliczenie
{
    public static class Helper
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
        public static void Wait()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Generate sample data"); Console.WriteLine("[2] Display all solids"); Console.WriteLine("[3] Default sort"); Console.WriteLine("[4] Sort by Surface"); Console.WriteLine("[5] Filter by name"); Console.WriteLine("[0] Exit");
        }
    }
}
