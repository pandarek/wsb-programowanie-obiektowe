using System;
namespace TravelOffice
{
    [Serializable]
    public class Address
    {
        private string _street;
        private string _zip;
        private string _city;

        public Address() { }

        public Address(string street, string zip, string city)
        {
            this._street = street;
            this._zip = zip;
            this._city = city;
        }

        public string Zip { get => _zip; set => _zip = value; }

        public string City { get => _city; set => _city = value; }

        public string Street { get => _street; set => _street = value; }

        public override string ToString()
        {
            return $"Adres: {_street}, {_zip} {_city}";
        }
    }
}
