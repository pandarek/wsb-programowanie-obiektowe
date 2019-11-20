using System;
using System.IO;
using System.Xml.Serialization;

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

            

            Car car = new Car();

            BinarySerializer binarySerializer = new BinarySerializer();
            XMLSerializer xmlSerializer = new XMLSerializer();

            
                   
            bool exit = false;

            while (!exit)
            {
                Helper.MainMenu();
                switch (Helper.PodajLiczbe("\nWybierz opcję: "))
                {
                    case 1:
                        Console.Write("Marka samochodu: ");
                        var brand = Console.ReadLine();
                        Console.Write("Model samochodu: ");
                        var model = Console.ReadLine();
                        var enginecapacity = Helper.PodajLiczbe("Pojemność silnika (cm³): ");
                        var tankcapacity = Helper.PodajLiczbe("Pojemność zbiornika paliwa (l): ");
                        bool fuel_check = false;

                        double fuel = 0;

                        while (!fuel_check)
                        {
                            fuel = Helper.PodajLiczbeDouble("Ile masz paliwa (l): ");
                            if (fuel > tankcapacity)
                            {
                                Console.WriteLine($"Za dużo paliwa, pojemność zbiornika: {tankcapacity} l");
                            }
                            else
                            {
                                fuel_check = true;
                            }
                        }

                        car = new Car(brand, model, enginecapacity, fuel, tankcapacity);
                        break;

                    case 2:
                        xmlSerializer.Serializer(car);
                        //binarySerializer.Serializer(car);
                        Helper.Wait();
                        break;

                    case 3:
                        //using (TextReader read = new StreamReader(@"./car.xml"))
                        //{
                        //    //Car car = new Car();
                        //    XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Car));
                        //    car = (Car)xmlSerializer2.Deserialize(read);
                        //    Console.WriteLine("Data loaded");
                        //}
                        //car = new Car();
                        xmlSerializer.DeSerializer(car);
                        //binarySerializer.Deserializer(car);
                        Helper.Wait();
                        break;

                    case 4:
                        Console.WriteLine(car.CarInfo());
                        Helper.Wait();
                        break;

                    case 5:
                        if (car.Fuel <= 0)
                        {
                            Console.WriteLine("\nNie ma paliwa, nie możesz jechać\n");
                            Helper.Wait();
                            break;
                        }
                        var distance = Helper.PodajLiczbe("Jaki dystans chcesz pokonać: ");
                        car.go(distance);
                        Helper.Wait();
                        break;

                    case 6:
                        car.refueling();
                        Helper.Wait();
                        break;
                        
                    case 7:
                        exit = true;
                        break;

                }
            }

        }
    }
}
