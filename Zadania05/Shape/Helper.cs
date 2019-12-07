using System;
using System.Collections.Generic;

namespace Shape
{
    public class Helper
    {

        public static int GetInt(string msg)
        {
            Console.Write(msg);
            int r = 0;
            if (!int.TryParse(Console.ReadLine(), out r))
            {
                throw new ArgumentException("Couldn't parse input into integer");
            }
            return r;
        }
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Generate sample data"); Console.WriteLine("[2] Default sort"); Console.WriteLine("[3] Sort by Circut"); Console.WriteLine("[4] Filter by Shape type"); Console.WriteLine("[5] Display shapes"); Console.WriteLine("[0] Exit");
        }

        
    }
}
