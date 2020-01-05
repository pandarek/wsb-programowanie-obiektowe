using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace HotelDrCsharp
{
    public static class SerializeXML
    {
        
        public static void SaveRoomData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));

            using (TextWriter writer = new StreamWriter(@"./hoteldata.xml"))
            {
                serializer.Serialize(writer, Hotel.hotellist);
                Console.WriteLine("Dane pokoji zapisane");
            }

        }

        public static void LoadRoomData()
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));

                using (TextReader reader = new StreamReader(@"./hoteldata.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    Hotel.hotellist = (List<Room>)obj;
                    Console.WriteLine("Dane pokoji wczytane");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void SaveReservationData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Reservation>));

            using (TextWriter writer = new StreamWriter(@"./reservationdata.xml"))
            {
                
                serializer.Serialize(writer, Program.hotel.ReservationsList);
                Console.WriteLine("Dane rezerwacji zapisane");
            }

        }
        public static void LoadReservationData()
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Reservation>));

                using (TextReader reader = new StreamReader(@"./reservationdata.xml"))
                {
                    var obj = serializer.Deserialize(reader);

                    //Hotel hotel = new Hotel();

                    Program.hotel.ReservationsList = (List<Reservation>)obj;
                    Console.WriteLine("Dane rezerwacji wczytane");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
