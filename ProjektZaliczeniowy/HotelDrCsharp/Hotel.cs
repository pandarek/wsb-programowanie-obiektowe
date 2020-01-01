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
<<<<<<< HEAD
            new Room{Roomnumber = 9, Roomsize = 1}
=======
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
            
>>>>>>> 7d4ed57ca288351d1eac0c11de060893820194f6
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