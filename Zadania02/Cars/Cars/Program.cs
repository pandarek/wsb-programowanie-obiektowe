using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine(1500, 45);
            Engine engine2 = new Engine(1500, 45, 80);

            Car car = new Car();

            car.go(50);
            
            Console.ReadKey();
        }
    }
}
