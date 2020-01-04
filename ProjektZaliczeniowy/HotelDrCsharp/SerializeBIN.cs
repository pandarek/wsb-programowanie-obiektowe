using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;

namespace HotelDrCsharp
{
    public static class SerializeBIN
    {
        
        public static void SaveUsers()
        {

            try
            {
                IFormatter formatter = new BinaryFormatter();

                using (Stream stream = new FileStream(@"./users.bin", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, Program.users);
                }
                Console.WriteLine("Dane użytkowników zapisane");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void LoadUsers()
        {

            try
            {
                IFormatter formatter = new BinaryFormatter();

                using (Stream stream = new FileStream(@"./users.bin", FileMode.Open, FileAccess.Read))
                {
                    var obj = formatter.Deserialize(stream);
                    Program.users = (List<User>)obj;
                }
                Console.WriteLine("Dane użytkowników wczytane");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
