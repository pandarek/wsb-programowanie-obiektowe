using System;
namespace HotelDrCsharp
{
    public class Room
    {
        private bool _status;
        private int _roomnumber;
        private int _roomsize;
        private Customer _customer;
        private DateTime _startdate;
        private DateTime _enddate;

        public Room() { }

        public Room(int _roomnumber, int _roomsize, bool _status = false, Customer _customer = null, DateTime? _startdate = null, DateTime? _enddate = null)
        {
            this._status = Status;
            this._roomnumber = Roomnumber;
            this._roomsize = Roomsize;
            this._customer = Customer;
            this._startdate = StartDate;
            this._enddate = EndDate;
        }

        public bool Status { get; set; }
        public int Roomsize { get; set; }
        public int Roomnumber { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        
        public void book()
        {
            if (Status)
            {
                
                Console.WriteLine("\nPokój już zarezerwowany");
                Helper.Wait();
                
            }
            else
            {
                Customer = Reservation.AddCustomer();

                StartDate = Reservation.AddStartDate();
                
                EndDate = Reservation.AddEndDate(StartDate);

                Status = true;
                
                Console.WriteLine($"\nPokój {Roomnumber} Rezerwacja dokonana");
                Helper.Wait();
            }
        }

        public void cancelreservation()
        {
            if (!Status)
            {
                Console.WriteLine("\nPokój nie jest zarezerwowany");
                Helper.Wait();
            }
            else
            {
                Status = false;
                Customer = null;
                StartDate = new DateTime();
                EndDate = new DateTime();
                Console.WriteLine($"\nRezerwacja {Roomnumber} anulowana");
                Helper.Wait();
            }
        }

        public override string ToString()
        {
            string status = (Status) ? "rezerwcja" : "wolne";
            if (Status)
            {
                return $"Pokój: {Roomnumber}, Status: {status} od: {StartDate.ToString("yyyy-MM-dd")} do {EndDate.ToString("yyyy-MM-dd")}, \nKlinet: {Customer}";
            }

            return $"Pokój: {Roomnumber}, Status: {status}";
        }
    }
}