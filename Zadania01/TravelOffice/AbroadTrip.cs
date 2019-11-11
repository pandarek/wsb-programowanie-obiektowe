using System;
using System.Xml.Serialization;

namespace TravelOffice
{

    public class AbroadTrip : Trip
    {
        private const int DefaultInsurance = 10;

        private int _insurance;

        public AbroadTrip() { }

        public AbroadTrip(Date start, Date end, string destination, int Insurance = DefaultInsurance ) : base(start, end, destination)
        {
            this._insurance = Insurance;
            getPrice(Insurance);
        }

        public int Insurance
        {
            get => _insurance;
            set => _insurance = value;
        }

        public decimal getPrice(int Insurance)
        {

            decimal price = Price;
                         
            Price = price + Insurance;

            return price + Insurance;

        }
    }
}
