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
            //ReservationsList.ForEach(Console.WriteLine);

            int roomnumber = Helper.InputIntRange("Podaj numer pokoju: ", 1, 30);
            
            DateTime StartDate = Helper.AddStartDate();

            DateTime EndDate = Helper.AddEndDate(StartDate);

            //Sprawdzenie czy dany pokój jest dostępny w danym terminie
            bool dateoverlapcheck = DateOverlap(roomnumber, StartDate, EndDate);

            if (!dateoverlapcheck)
            {
                Customer customer = Helper.AddCustomer();
                Reservation reservation = new Reservation(roomnumber,customer,StartDate,EndDate);
                ReservationsList.Add(reservation);
                hotellist[roomnumber - 1].Status = true;
                Console.WriteLine($"\nDodano rezerwację nr {reservation.Id}\n");
                Console.WriteLine(reservation);
            }
            else
            {
                Console.WriteLine($"\nPokój {roomnumber} w wybranym ternie jest niedostępny\n");
            }

        }

        //Usuwanie rezerwacji
        public void RemoveReservation()
        {
            ReservationsList.ForEach(Console.WriteLine);
            int id = Helper.InputInt("Podaj numer rezerwacji: ");

            //Sprawdzenie czy rezerwacja istnieje
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

        //Sprawdzenie czy pokój jest dostępny w danym terminie (nakłdanie dat)
        public bool DateOverlap(int room, DateTime start, DateTime end)
        {

            int i = 0;

            foreach (var item in ReservationsList.FindAll(item => item.Roomnumber == room))
            {
                //Console.WriteLine("Sprawdzana rezerewacja: " + item);
                //Console.WriteLine($"\nSprawdzane dane:\n {item.StartDate} = {start} \n{item.EndDate} = {end}\n");
                if ((item.StartDate < end) && (start < item.EndDate))
                {
                    i++;
                }
             }

            //Console.WriteLine("wynik:" + i);

            if (i == 0) { return false; }
            return true;
        }


        public override string ToString()
        {
            int freerooms = hotellist.Count();
            int reservations = Program.hotel.ReservationsList.Count();

            foreach (var item in hotellist)
            {
                 if (item.Status == true) freerooms--;
            }


            return $"Wolne pokoje: {freerooms}, Rezerwacje: {reservations}\n";

        }
    }
}