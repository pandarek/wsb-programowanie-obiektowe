using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {

            Engine engine1 = new Engine(1500, 45);
            Engine engine2 = new Engine(2000, 70, 80);

            Car car1 = new Car("VW", "Golf", engine1);
            Car car2 = new Car("Opel", "Astra", 1300, 30);
            Car car3 = new Car("Opel", "Astra", 1200, 30, 48);

            //car1.go(50);

            //car2.go(60);

            //car3.go(20);

            //car3.tankuj();

            //car3.go(20);

            Helper.AddCar();

            
            Console.WriteLine("Naciśnij dowolny kalwisz...");
            Console.ReadKey();

        }
    }
}
