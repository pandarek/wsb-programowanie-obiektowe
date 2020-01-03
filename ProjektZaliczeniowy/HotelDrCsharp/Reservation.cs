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
            DateTime ToDay = DateTime.Today.ToLocalTime();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Wprowadź datę przyjazdu format (RRRR-MM-DD)");

            string date;
            bool dataok;

            do
            {
                date = Console.ReadLine();
                dataok = DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out startdate);

                if (!dataok) { Console.WriteLine("Bład daty: wprowadź ponownie"); }
                if (startdate < ToDay) { Console.WriteLine("Bład daty: data przeszła, wprowadź ponownie"); }

            } while (!dataok || (startdate < ToDay));

            return startdate;

        }

        public static DateTime AddEndDate(DateTime startdate)
        {

            DateTime enddate;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Wprowadź datę wyjazdu format (RRRR-MM-DD)");

            string date;
            bool dataok;

            do
            {
                date = Console.ReadLine();
                dataok = DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out enddate);

                if (!dataok) { Console.WriteLine("Bład daty: wprowadź ponownie"); }
                if (startdate >= enddate) { Console.WriteLine("Błąd daty: Data wyjazdu nie móże być wcześniej niż data przyjazdu, wprowadź ponownie"); }

            } while (!dataok || startdate >= enddate);

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