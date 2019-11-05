using System;
namespace TravelOffice
{
    public class DomesticTrip : Trip
    {
        private const int DefaultDiscount = 10;

        private int _ownArrivalDiscount;

        public DomesticTrip(Date start, Date end, string destination, int OwnArrivalDiscount = DefaultDiscount) : base(start, end, destination)
        {
            this._ownArrivalDiscount = OwnArrivalDiscount;
            getPrice(OwnArrivalDiscount);
        }

        public int OwnArrivalDiscount
        {
            get => _ownArrivalDiscount;
            set => _ownArrivalDiscount = value;
        }

        public decimal getPrice(int OwnArrivalDiscount)
        {

            decimal price = Price;

            Price = price - OwnArrivalDiscount;

            return price - OwnArrivalDiscount;

        }

    }
}