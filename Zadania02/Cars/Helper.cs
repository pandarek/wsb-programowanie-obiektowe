using System;
namespace Cars
{
    public class Helper
    {
        public static int PodajLiczbe(string wiadomosc)
        {

            bool udalosoe = false;
            int result = 0;
            while ((!udalosoe) || (result < 1))
            {
                Console.Write(wiadomosc);
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            }
            return result;
        }
        public static void AddCar()
        {
            Console.WriteLine("Marka samochodu:");
            var brand = Console.ReadLine();
            Console.WriteLine("Model samochodu:");
            var model = Console.ReadLine();
            var enginecapacity = Helper.PodajLiczbe("Pojemniść silnika: ");
            var fuel = Helper.PodajLiczbe("Ile masz paliwa: ");
            var distance = Helper.PodajLiczbe("Jaki dystans chce pokonać: ");

            Car car = new Car(brand, model, enginecapacity, fuel);

            car.go(distance);



        }
    }
}
