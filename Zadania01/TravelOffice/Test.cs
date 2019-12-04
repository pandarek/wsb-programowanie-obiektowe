using System;
using System.IO;
using System.Xml.Serialization;

namespace TravelOffice
{
    public class Test
    {

        static void Main(string[] args)
        {
            //TravelOffice travelOffice = new TravelOffice();

            //XmlSerializer deserializer = new XmlSerializer(typeof(Customer[]), new Type[] { typeof(Trip), typeof(DomesticTrip), typeof(AbroadTrip) });

            ////Customer[] customers;

            //try
            //{
            //    using (TextReader reader = new StreamReader(@"./mojedane.xml"))
            //    {

            //        travelOffice.Customers = (Customer[]) deserializer.Deserialize(reader);

            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            SerializeXML serializer = new SerializeXML();
            TravelOffice travelOffice = new TravelOffice();

            bool menu = false;

            while (!menu)
            {
                Helper.menu();
                


                switch (Helper.readcorrectkey("Chose option...: "))
                {
                    case 1:
                        serializer.deserialize(travelOffice);
                        Helper.wait();
                        break;
                    case 2:

                        Date start = new Date(2019, 11, 12);
                        Date end = new Date(2019, 11, 30);

                        Date start1 = new Date(2019, 12, 12);
                        Date end1 = new Date(2019, 12, 30);

                        //Trip trip1 = new Trip(start, end, "Poznań");
                        //trip1.getPrice("Podaj cenę wycieczki 1: ");

                        Trip trip2 = new Trip(start1, end1, "Warszawa");
                        trip2.getPrice("Podaj cenę wycieczki 2: ");

                        Trip abroadTrip = new AbroadTrip(start1, end1, "Warszawa");

                        DomesticTrip domesticTrip = new DomesticTrip(start, end, "Poznań");

                        //klient 1
                        Customer customer1 = new Customer("Pan Darek");
                        Address address1 = new Address("Kuśnierska 4", "62-020", "Swarzędz");

                        customer1.Address = address1;
                        customer1.Trip = domesticTrip;


                        //klient 2
                        Customer customer2 = new Customer("Karolona Kowalska");
                        Address address2 = new Address("Szkolna 20/3", "60-241", "Wrocław");

                        customer2.Address = address2;
                        customer2.Trip = abroadTrip;


                        //klient 3
                        Customer customer3 = new Customer("Adam Nowak");
                        Address address3 = new Address("Oryfeusza 18", "82-241", "Gdańsk");

                        customer3.Address = address3;
                        customer3.Trip = trip2;


                        //dodanie klienta do bazy
                        travelOffice.AddCustomer(customer1);
                        travelOffice.AddCustomer(customer2);
                        travelOffice.AddCustomer(customer3);

                        Helper.wait();
                        break;
                    case 3:
                        serializer.serialize(travelOffice.Customers);
                        Helper.wait();
                        break;

                    case 4:
                        Console.WriteLine(travelOffice.getInfo());
                        Helper.wait();
                        break;

                    case 5:
                        travelOffice.ClearCustomers();
                        Helper.wait();
                        break;

                    case 6:
                        menu = true;
                        break;

                }
            }


            //raport z biura



        }


    }
}
