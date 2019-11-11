using System;
namespace TravelOffice
{
    
    public class Trip
    {
        private const decimal DefaultPrice = 100;
        private Date _start;
        private Date _end;
        private string _destination;
        private decimal _price;

        public Trip() { }

        public Trip(Date start, Date end, string destination, decimal Price = DefaultPrice)
        {
            this._start = start;
            this._end = end;
            this._destination = destination;
            this._price = Price;
        }

        public decimal Price { get => _price; set => _price = value; }
        public Date Start { get => _start; set => _start = value; }
        public Date End { get => _end; set => _end = value; }
        public string Destination { get => _destination; set => _destination = value; }

        public void getPrice(string cena)
        {
            Console.WriteLine("Podaj cenę wycieczki: ");
            Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"cena: {Price}\n");
        }

        public override string ToString()
        {
            return $"Wycieczka z {_destination} od {_start} do {_end} cena {Price}";

        }
    }
}
