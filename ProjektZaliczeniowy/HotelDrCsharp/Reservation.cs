using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotelDrCsharp
{

    public class Reservation
    {
        private int _id;
        private int _roomnumber;
        private Customer _customer;
        private DateTime _startdate;
        private DateTime _enddate;

        public Reservation()
        {
        }

        public Reservation(int Roomnumber, Customer Customer, DateTime StartDate, DateTime EndDate)
        {
            this._roomnumber = Roomnumber;
            this._customer = Customer;
            this._startdate = StartDate;
            this._enddate = EndDate;
            this._id = GetHashCode();
        }

        public int Roomnumber { get; set; }
        public int Id { get => _id; set => _id = value; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Customer Customer { get; set; }

        public override string ToString()
        {
            return $"Nr: {_id}, Pokoj: {_roomnumber}, {_customer}, {_startdate}, {_enddate}";
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