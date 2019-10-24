using System;
namespace TravelOffice
{
    public class Customer
    {
        private string name;
        private Address address;
        private Trip trip;

        

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Address Address
        {
            get => address;

            set => address = value;
           
        }
        public Trip Trip
        {
            get => trip;
            set => trip = value;
        }

        public Customer(string name)
        {
            this.name = name;
        }

        public string getInfo()
        {
           return $"Klient {name} \n {address.getInfo()} \n {trip.getInfo()}";
        }
    }
}
