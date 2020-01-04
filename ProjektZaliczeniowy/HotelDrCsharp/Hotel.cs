using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelDrCsharp
{
    public class Hotel
    {
        public List<Reservation> ReservationsList = new List<Reservation>();
        public static List<Room> hotellist = new List<Room>
        {
            new Room{Roomnumber = 1, Roomsize = 1},
            new Room{Roomnumber = 2, Roomsize = 1},
            new Room{Roomnumber = 3, Roomsize = 1},
            new Room{Roomnumber = 4, Roomsize = 1},
            new Room{Roomnumber = 5, Roomsize = 1},
            new Room{Roomnumber = 6, Roomsize = 1},
            new Room{Roomnumber = 7, Roomsize = 1},
            new Room{Roomnumber = 8, Roomsize = 1},
            new Room{Roomnumber = 9, Roomsize = 1},
            new Room{Roomnumber = 10, Roomsize = 1},
            new Room{Roomnumber = 11, Roomsize = 2},
            new Room{Roomnumber = 12, Roomsize = 2},
            new Room{Roomnumber = 13, Roomsize = 2},
            new Room{Roomnumber = 14, Roomsize = 2},
            new Room{Roomnumber = 15, Roomsize = 2},
            new Room{Roomnumber = 16, Roomsize = 2},
            new Room{Roomnumber = 17, Roomsize = 2},
            new Room{Roomnumber = 18, Roomsize = 2},
            new Room{Roomnumber = 19, Roomsize = 2},
            new Room{Roomnumber = 20, Roomsize = 2},
            new Room{Roomnumber = 21, Roomsize = 3},
            new Room{Roomnumber = 22, Roomsize = 3},
            new Room{Roomnumber = 23, Roomsize = 3},
            new Room{Roomnumber = 24, Roomsize = 3},
            new Room{Roomnumber = 25, Roomsize = 3},
            new Room{Roomnumber = 26, Roomsize = 3},
            new Room{Roomnumber = 27, Roomsize = 3},
            new Room{Roomnumber = 28, Roomsize = 3},
            new Room{Roomnumber = 29, Roomsize = 3},
            new Room{Roomnumber = 30, Roomsize = 3}
        };


        public void AddReservation()
        {
            ReservationsList.ForEach(Console.WriteLine);
            int roomnumber = Helper.InputIntRange("Podaj numer pokoju: ", 1, 30);

            Customer customer = Helper.AddCustomer();

            DateTime StartDate = Helper.AddStartDate();

            DateTime EndDate = Helper.AddEndDate(StartDate);

            if (true)
            {
                Reservation reservation = new Reservation(roomnumber, customer, StartDate, EndDate);
                ReservationsList.Add(reservation);
                hotellist[roomnumber - 1].Status = true;
            }
            else
            {
                Console.WriteLine("daty się nakładają");
            }

        }

        public void RemoveReservation()
        {
            ReservationsList.ForEach(Console.WriteLine);
            int id = Helper.InputInt("Podaj numer rezerwacji: ");

            var itemToRemove = ReservationsList.Single(item => item.Id == id);
            ReservationsList.Remove(itemToRemove);

            ReservationsList.ForEach(Console.WriteLine);
            Helper.Wait();
        }

        //public bool Date(int room, DateTime start, DateTime end)
        //{
        //    //return ReservationsList.Any(s => s.Roomnumber == room);
        //    return ReservationsList.Any(s => s.Roomnumber == room && ((start > s.EndDate && end > s.EndDate) || (start < s.StartDate && end < s.StartDate))  );

        //}


        public static void ToString()
        {
            foreach (var item in hotellist)
            {
                string status = (item.Status == true) ? "rezerwcja" : "wolne";
                if (item.Status)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Numer pokoju: {item.Roomnumber}, Ilość pokoi: {item.Roomsize}, Status: {status}");
                    Console.WriteLine($"Klient: {item.Customer}");
                    Console.WriteLine($"Od: {item.StartDate.ToString("yyyy-MM-dd")} do: {item.EndDate.ToString("yyyy-MM-dd")}");
                }
                else
                {
                    //string customer = (item.Status == true) ? $"\nKlinet: {item.Customer.ToString()}" : "";
                    Console.WriteLine($"Numer pokoju: {item.Roomnumber}, Ilość pokoi: {item.Roomsize}, Status: {status}");
                }
            }
        }
    }
}
