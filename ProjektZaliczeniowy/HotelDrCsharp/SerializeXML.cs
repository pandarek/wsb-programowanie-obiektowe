using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace HotelDrCsharp
{
    public class SerializeXML
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));

        public void savexml(List<Room> hotellist)
        {

            using (TextWriter writer = new StreamWriter(@"./hoteldata.xml"))
            {
                serializer.Serialize(writer, hotellist);
                Console.WriteLine("Dane hotelu zapisane");
            }

        }
        public void deserialize()
        {

            try
            {
                using (TextReader reader = new StreamReader(@"./hoteldata.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    Hotel.hotellist = (List<Room>)obj;
                    Console.WriteLine("Dane hotelu wczytane");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
