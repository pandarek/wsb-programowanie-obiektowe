using System;
namespace HotelDrCsharp
{
    public class Room
    {
        private bool _status;
        private int _roomnumber;
        private int _roomsize;
        private Customer _customer;

        public Room()
        {
            _status = true;
            _roomnumber = 0;
            _roomsize = 1;
        }


        public void book()
        {

        }

        public void cancelreservations()
        {

        }
    }
}