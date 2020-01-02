using System;
namespace HotelDrCsharp
{
    public class Room
    {
        private bool _status;
        private int _roomnumber;
        private int _roomsize;
        private Customer _customer;

        public Room() { }

        public Room(int _roomnumber, int _roomsize, bool _status = false, Customer _customer = null)
        {
            this._status = Status;
            this._roomnumber = Roomnumber;
            this._roomsize = Roomsize;
            this._customer = Customer;
        }

        public bool Status { get; set; }
        public int Roomsize { get; set; }
        public int Roomnumber { get; set; }
        public Customer Customer { get; set; }
        
        public void book()
        {
            if (Status)
            {
                
                Console.WriteLine("\nPokój już zarezerwowany");
                Helper.Wait();
                
            }
            else
            {
                Customer = AddCustomer();
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
                Console.WriteLine($"\nRezerwacja {Roomnumber} anulowana");
                Helper.Wait();
            }
        }

        private Customer AddCustomer()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Podaj imię:\t\t\t");
            var imie = Console.ReadLine();
            Console.Write("Podaj Nazwisko:\t\t\t");
            var nazwisko = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            Customer customer = new Customer(imie,nazwisko);

            return customer;
        }



        public override string ToString()
        {
            string status = (Status) ? "rezerwcja" : "wolne";
            if (Status)
            {
                return $"Pokój: {Roomnumber}, Status: {status}, Klinet: {Customer}";
            }

            return $"Pokój: {Roomnumber}, Status: {status}";
        }
    }
}