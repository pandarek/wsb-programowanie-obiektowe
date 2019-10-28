using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {

            //Engine engine1 = new Engine(1500, 45);
            //Engine engine2 = new Engine(2000, 70, 80);

            //Car car1 = new Car("VW", "Golf", engine1);
            //Car car2 = new Car("Opel", "Astra", 1300, 30);
            //Car car3 = new Car("Opel", "Astra", 1200, 30, 48);

            //car1.go(50);

            //car2.go(60);

            //car3.go(20);

            //car3.tankuj();

            //car3.go(20);

         

           
            Console.Write("Marka samochodu: ");
            var brand = Console.ReadLine();
            Console.Write("Model samochodu: ");
            var model = Console.ReadLine();
            var enginecapacity = Helper.PodajLiczbe("Pojemność silnika (cm³): ");
            var tankcapacity = Helper.PodajLiczbe("Pojemność zbiornika paliwa (l): ");
            var fuel = Helper.PodajLiczbeDouble("Ile masz paliwa (l): ");
            

            Car car = new Car(brand, model, enginecapacity, fuel, tankcapacity);

            //car.go(distance);

            

            

            bool exit = false;

            while (!exit)
            {
                Helper.MainMenu();
                switch (Helper.PodajLiczbe("\nWybierz opcję: "))
                {
                    case 1:
                        Console.WriteLine(car.CarInfo());
                        Helper.Wait();
                        break;

                    case 2:
                        if (car.Fuel <= 0)
                        {
                            Console.WriteLine("\nNie ma paliwa\n");
                            Helper.Wait();
                            break;
                        }
                        var distance = Helper.PodajLiczbe("Jaki dystans chcesz pokonać: ");
                        car.go(distance);
                        Helper.Wait();
                        break;

                    case 3:
                        car.tankuj();
                        Helper.Wait();
                        break;
                        
                    case 4:
                        exit = true;
                        break;

                }
            }

            


            //Console.WriteLine("Naciśnij dowolny kalwisz...");
            //Console.ReadKey();

        }
    }
}
