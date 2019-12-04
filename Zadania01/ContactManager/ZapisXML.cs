using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;
namespace ContactManager
{
    public class ZapisXML
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>), new XmlRootAttribute("Kontakty"));

        public void zapisz(List<Osoba> kontakty)
        {
            using (TextWriter writer = new StreamWriter(@"./kontakty.xml"))
            {
                
                serializer.Serialize(writer, kontakty);
                Console.WriteLine("Kontakty zapisane");
            }
        }
        public void wczytaj(Kontakty kontakty)
        {
            try
            {
                using (TextReader stringReader = new StreamReader(@"./kontakty.xml"))
                {
                    // Kontakty kontakty = new Kontakty();
                    kontakty.KontaktyLista = (List<Osoba>)serializer.Deserialize(stringReader);
                    Console.WriteLine("Kontakty wczytane");
                    Console.WriteLine(kontakty.KontaktyLista.Count);
                }
              

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
