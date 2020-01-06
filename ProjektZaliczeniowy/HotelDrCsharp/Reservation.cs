using System;

using System.Xml.Serialization;

namespace HotelDrCsharp
{
    [Serializable]
    public class Reservation
    {
        private int _id;
        private int _roomnumber;
        private Customer _customer;
        private DateTime _startdate;
        private DateTime _enddate;
        private DateTime startDate;
        private DateTime endDate;
        private Customer customer;

        public Reservation() { }

        public Reservation(int Roomnumber, Customer Customer, DateTime StartDate, DateTime EndDate)
        {
            this._roomnumber = Roomnumber;
            this._customer = Customer;
            this._startdate = StartDate;
            this._enddate = EndDate;
            this._id = GetHashCode();
        }
        public Reservation(int Roomnumber)
        {
            this._roomnumber = Roomnumber;
            this._id = GetHashCode();
        }


        public int Roomnumber { get => _roomnumber; set => _roomnumber = value; }
        public int Id { get => _id; set => _id = value; }
        public DateTime StartDate { get => _startdate; set => _startdate = value; }
        public DateTime EndDate { get => _enddate; set => _enddate = value; }
        public Customer Customer { get => _customer; set => _customer = value; }

        public override string ToString()
        {
            return $"Nr: {_id}, Pokoj: {_roomnumber},\nKlient: {_customer}, \nOd: {_startdate.ToString("yyyy-MM-dd")}, Do: {_enddate.ToString("yyyy-MM-dd")}\n";
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