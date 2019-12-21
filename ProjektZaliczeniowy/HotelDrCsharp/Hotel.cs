using System;
using System.Collections.Generic;

namespace HotelDrCsharp
{
    public class Hotel
    {
        static public int rooms = 30;
        //public static List<Room> hotel = new List<Room>();
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
            new Room{Roomnumber = 9, Roomsize = 1}

        };

        public void ToString()
        {
            
            foreach (var item in hotellist)
            {
                string status = (item.Status == true) ? "rezerwcja" : "wolne";
                Console.WriteLine($"Numer pokoju: {item.Roomnumber}, Ilość pokoi: {item.Roomsize}, Status: {status}");
            }
          
        }
    }
}
