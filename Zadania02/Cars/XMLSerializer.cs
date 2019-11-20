using System;
using System.IO;
using System.Xml.Serialization;

namespace Cars
{
    public class XMLSerializer
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car));

        public XMLSerializer()
        {
            
            Console.WriteLine("Serializer uruchomiony");
        }

        public void Serializer(Car car)
        {
            try
            {
                using (TextWriter write = new StreamWriter(@"./car.xml"))
                {
                    xmlSerializer.Serialize(write, car);
                    Console.WriteLine("Data saved");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeSerializer(Car car)
        {
           
                using (TextReader read = new StreamReader(@"./car.xml"))
                {
                  
                   car = (Car)xmlSerializer.Deserialize(read);
                   Console.WriteLine("Data loaded");
                }
         
        }

    }
}
