using System;
namespace TravelOffice
{
    public class Address
    {
        private string street;
        private string zip;
        private string city;

        public Address(string street, string zip, string city)
        {
            this.street = street;
            this.zip = zip;
            this.city = city;
        }

        public string getInfo()
        {
            return $"Adres: {street}, {zip} {city}";
        }
    }
}
