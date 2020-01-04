using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace HotelDrCsharp
{
    public static class SerializeXML
    {
        
        public static void SaveHotelData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));

            using (TextWriter writer = new StreamWriter(@"./hoteldata.xml"))
            {
                serializer.Serialize(writer, Hotel.hotellist);
                Console.WriteLine("Dane hotelu zapisane");
            }

        }
        public static void LoadHotelData()
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));

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
