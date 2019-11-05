using System;
namespace TravelOffice
{
    public class Address
    {
        private string _street;
        private string _zip;
        private string _city;

        public Address(string street, string zip, string city)
        {
            this._street = street;
            this._zip = zip;
            this._city = city;
        }

        public override string ToString()
        {
            return $"Adres: {_street}, {_zip} {_city}";
        }
    }
}
