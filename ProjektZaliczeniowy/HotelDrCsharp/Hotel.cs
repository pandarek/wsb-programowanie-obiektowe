using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace HotelDrCsharp
{
    public class Hotel
    {
        private List<Reservation> _reservationsList = new List<Reservation>();

        public static List<Room> hotellist = new List<Room>
        {
            new Room{Roomnumber = 1, Roomsize = 1},  new Room{Roomnumber = 2, Roomsize = 1},
            new Room{Roomnumber = 3, Roomsize = 1},  new Room{Roomnumber = 4, Roomsize = 1},
            new Room{Roomnumber = 5, Roomsize = 1},  new Room{Roomnumber = 6, Roomsize = 1},
            new Room{Roomnumber = 7, Roomsize = 1},  new Room{Roomnumber = 8, Roomsize = 1},
            new Room{Roomnumber = 9, Roomsize = 1},  new Room{Roomnumber = 10, Roomsize = 1},
            new Room{Roomnumber = 11, Roomsize = 2}, new Room{Roomnumber = 12, Roomsize = 2},
            new Room{Roomnumber = 13, Roomsize = 2}, new Room{Roomnumber = 14, Roomsize = 2},
            new Room{Roomnumber = 15, Roomsize = 2}, new Room{Roomnumber = 16, Roomsize = 2},
            new Room{Roomnumber = 17, Roomsize = 2}, new Room{Roomnumber = 18, Roomsize = 2},
            new Room{Roomnumber = 19, Roomsize = 2}, new Room{Roomnumber = 20, Roomsize = 2},
            new Room{Roomnumber = 21, Roomsize = 3}, new Room{Roomnumber = 22, Roomsize = 3},
            new Room{Roomnumber = 23, Roomsize = 3}, new Room{Roomnumber = 24, Roomsize = 3},
            new Room{Roomnumber = 25, Roomsize = 3}, new Room{Roomnumber = 26, Roomsize = 3},
            new Room{Roomnumber = 27, Roomsize = 3}, new Room{Roomnumber = 28, Roomsize = 3},
            new Room{Roomnumber = 29, Roomsize = 3}, new Room{Roomnumber = 30, Roomsize = 3}
        };

        [XmlArray]
        public List<Reservation> ReservationsList { get => _reservationsList; set => _reservationsList = value; }


        //Dodawanie rezerwacji
        public void AddReservation()
        {
            Console.Clear();
            Console.WriteLine("Dodawanie Rezerwacji\n");
            //ReservationsList.ForEach(Console.WriteLine);

            int roomnumber = Helper.InputIntRange("Podaj numer pokoju: ", 1, 30);

            Customer customer = Helper.AddCustomer();

            DateTime StartDate = Helper.AddStartDate();

            DateTime EndDate = Helper.AddEndDate(StartDate);

            bool dateoverlapcheck = DateOverlap(roomnumber, StartDate, EndDate);

            foreach (var item in ReservationsList.FindAll(item => item.Roomnumber == roomnumber))
            {
                Console.WriteLine("---\n" + item + "\n---");
                
            }

            Console.WriteLine("jak jest " + dateoverlapcheck);

            if (!dateoverlapcheck)
            {
                Reservation reservation = new Reservation(roomnumber,customer,StartDate,EndDate);
                ReservationsList.Add(reservation);
                hotellist[roomnumber - 1].Status = true;
                Console.WriteLine($"Dodano rezerwację nr {reservation.Id}");
                Console.WriteLine(reservation);
            }
            else
            {
                Console.WriteLine("daty się nakładają");
            }

        }


        //Usuwanie rezerwacji
        public void RemoveReservation()
        {
            ReservationsList.ForEach(Console.WriteLine);
            int id = Helper.InputInt("Podaj numer rezerwacji: ");

            bool reservationexist = ReservationsList.Any(item => item.Id == id);
            if (!reservationexist)
            {
                Console.WriteLine($"Brak rezerwacji o numerze: {id}");
            }
            else
            {
                var itemToRemove = ReservationsList.Single(item => item.Id == id);
                ReservationsList.Remove(itemToRemove);

                int roomnumber = itemToRemove.Roomnumber;
                int count = ReservationsList.FindAll(item => item.Roomnumber == roomnumber).Count;

                if (count == 0)
                {
                    hotellist[roomnumber - 1].Status = false;
                }
                Console.WriteLine($"Usunięto rezerwację nr {itemToRemove.Id}");

                ReservationsList.ForEach(Console.WriteLine);
            }

        }


        public bool DateOverlap(int room, DateTime start, DateTime end)
        {
            // (StartDate1 <= EndDate2) and(EndDate1 >= StartDate2)
            //return ReservationsList.Any(s => s.Roomnumber == room);

            //overlap = a.start < b.end && b.start < a.end;


            foreach (var item in ReservationsList.FindAll(item => item.Roomnumber == room))
            {
                //Console.WriteLine(item);
                if ((item.StartDate < end) && (start < item.EndDate)) return true;

            }
            return false;
        }


        //public override string ToString()
        //{
        //    foreach (var item in hotellist)
        //    {
        //        string status = (item.Status == true) ? "rezerwcja" : "wolne";

        //        //string customer = (item.Status == true) ? $"\nKlinet: {item.Customer.ToString()}" : "";
        //        return $"Numer pokoju: {item.Roomnumber}, Ilość pokoi: {item.Roomsize}, Status: {status}";

        //    }
        //}
    }
}
