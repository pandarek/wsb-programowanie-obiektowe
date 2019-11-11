using System;
using System.Xml.Serialization;

namespace TravelOffice
{
    [Serializable]
    public class Customer
    {
        private string _name;
        private Address _address;
        private Trip _trip;

        public Customer() {
        }

        public Customer(string name)
        {
            this._name = name;
        }

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
        //[XmlIgnore]
        public Trip Trip
        {
            get => _trip;
            set => _trip = value;
        }

        public override string ToString()

        {
            return $"Klient {Name} \n {Address} \n {Trip}";
        }
    }
}
