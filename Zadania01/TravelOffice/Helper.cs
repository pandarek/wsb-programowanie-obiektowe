using System;
namespace TravelOffice
{
    public class Helper
    {
        public static void wait()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void menu()
        {
            Console.WriteLine("1. Read data from file");
            Console.WriteLine("2. Read examples data");
            Console.WriteLine("3. Save data to file");
            Console.WriteLine("4. Show Travel Office info");
            Console.WriteLine("5. Clear Travel Office");
            Console.WriteLine("6. Exit");

        }
        public static int readcorrectkey(string info)
        {
            bool correct = false;
            int result = 0;
            Console.WriteLine(info);

            while (!correct)
            {
                
                correct = int.TryParse(Console.ReadLine(), out result);

            }
            return result;
            
        }
    }

}
