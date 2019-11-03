using System;
namespace TravelOffice
{
    public class Trip
    {
        private Date start;
        private Date end;
        private string destination;

        public Trip(Date start, Date end, string destination)
        {

            this.start = start;
            this.end = end;
            this.destination = destination;
        }

        public string getInfo()
        {
            return $"Wycieczka z {destination} od {start} do {end}";

        }
    }
}
