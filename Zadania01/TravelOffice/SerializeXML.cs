using System;
using System.IO;
using System.Xml.Serialization;

namespace TravelOffice
{
    public class SerializeXML
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Customer[]), new Type[] { typeof(Trip), typeof(DomesticTrip), typeof(AbroadTrip), typeof (Date) });

        public void serialize(Customer[] customers)
        {
           
            using (TextWriter writer = new StreamWriter(@"./mojedane.xml"))
            {
                serializer.Serialize(writer, customers);
                Console.WriteLine("Data saved");
            }

        }
        public void deserialize(TravelOffice travelOffice)
        {

            try
            {
                using (TextReader reader = new StreamReader(@"./mojedane.xml"))
                {

                    travelOffice.Customers = (Customer[])serializer.Deserialize(reader);
                    Console.WriteLine("Data loaded");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
