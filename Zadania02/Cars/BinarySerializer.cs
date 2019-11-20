using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cars
{
    public class BinarySerializer
    {
        
        IFormatter binaryFormatter = new BinaryFormatter();

        public BinarySerializer()
        {
            Console.WriteLine("Serializer uruchomiony");
        }
        public void Serializer(Car car)
        {
            try
            {
                using (Stream read = new FileStream("car.dat", FileMode.Create, FileAccess.Write))
                {
                    binaryFormatter.Serialize(read, car);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Deserializer()
        {
            try
            {
                using (Stream read = new FileStream("car.dat", FileMode.Open, FileAccess.Read))
                {
                   Car car = (Car)binaryFormatter.Deserialize(read);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
