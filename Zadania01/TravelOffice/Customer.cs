using System;
namespace TravelOffice
{
    public class Customer
    {
        private string _name;
        private Address _address;
        private Trip _trip;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Address Address
        {
            get => _address;
            set => _address = value;

        }
        public Trip Trip
        {
            get => _trip;
            set => _trip = value;
        }

        public Customer(string name)
        {
            this._name = name;
        }

        public string getInfo()

        {
            return $"Klient {Name} \n {Address} \n {Trip}";
        }
    }
}
