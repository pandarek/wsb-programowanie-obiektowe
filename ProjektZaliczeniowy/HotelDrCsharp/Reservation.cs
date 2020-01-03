using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotelDrCsharp
{

    public static class Reservation
    {

        public static Customer AddCustomer()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Podaj imię:\t\t\t");
            var imie = Console.ReadLine();
            Console.Write("Podaj Nazwisko:\t\t\t");
            var nazwisko = Console.ReadLine();


            Customer customer = new Customer(imie, nazwisko);

            return customer;
        }

        public static DateTime AddStartDate()
        {
            DateTime startdate;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Wprowadź datę przyjazdu format (RRRR-MM-DD)");
            string line = Console.ReadLine();
            
            while (!DateTime.TryParseExact(line, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out startdate))
            {
                Console.WriteLine("Błędna data, wprowadź ponownie");
                line = Console.ReadLine();

            }

            return startdate;

        }

        public static DateTime AddEndDate()
        {

            DateTime enddate;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Wprowadź datę wyjazdu format (RRRR-MM-DD)");
            string line = Console.ReadLine();

            while (!DateTime.TryParseExact(line, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out enddate))
            {
                Console.WriteLine("Błędna data, wprowadź ponownie");
                line = Console.ReadLine();

            }

            return enddate;
        }

    }





    //    public class Bill 
    //{ 
    //    if (Room.Roomsize = 1)
    // {
    //        cost = 50; //PLN za dobę
    // }

    //    if (Room.Roomsize = 2)
    // {
    //        cost = 100; 
    // }

    //    if (Room.Roomsize = 3)
    // {
    //        cost = 150; 
    // }




    //    days = dateout - datein;
    //    billing = cost* days


    //}
}