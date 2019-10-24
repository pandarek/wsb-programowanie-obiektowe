using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProgemObiektowy
{
    class Program
    {
        static void Main(string[] args)
        {

            //punkt a
            Data start = new Data(2015, 7, 26);
            
            //punkt b
            Data end = new Data(2017, 7, 11);

            //punkt c
            Console.WriteLine(start);
            Console.WriteLine(end);
            Console.WriteLine();

            //punkt d
            Data today = start;
            Console.WriteLine(today);

            //punkt f
            today.Rok = 2016;
            today.Dzien = 17;

            Console.WriteLine(today);
            Console.WriteLine();
            
            //punkt h
            end = today;

            //punkt i
            Console.WriteLine(end);

            Console.ReadKey();
        }
    }
}
