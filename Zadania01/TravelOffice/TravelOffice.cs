using System;
namespace TravelOffice
{
    public class TravelOffice
    {


        static void Main(string[] args)
        {

            Date start = new Date(2019, 11, 12);
            Date end = new Date(2019, 11, 30);

            //klient 1
            Customer customer1 = new Customer("Pan Darek");
            Address address1 = new Address("Kuśnierska 4", "62-020", "Swarzędz");

            Trip trip1 = new Trip(start, end, "Poznań");

            customer1.Address = address1;
            customer1.Trip = trip1;

            //klient 2
            Customer customer2 = new Customer("Karolona Kowalska");
            Address address2 = new Address("Szkolna 20/3", "60-241", "Wrocław");

            customer2.Address = address2;
            customer2.Trip = trip1;

            //klient 3
            Customer customer3 = new Customer("Adam Nowak");
            Address address3 = new Address("Oryfeusza 18", "82-241", "Gdańsk");

            Trip trip2 = new Trip(start, end, "Warszawa");

            customer3.Address = address3;
            customer3.Trip = trip2;

            //dodanie klienta do bazy
            addCustomer(customer1);
            addCustomer(customer2);
            addCustomer(customer2);

            //raport z biura
            getInfo();

        }
        static string[] customers = new string[1];

        private static void addCustomer(Customer customer)
        {

            if (customers[0] == null)
            {
                customers[0] = customer.getInfo();
            }
            else
            {
                int records = customers.Length;

                string[] temp = new string[records + 1];
                customers.CopyTo(temp, 0);

                temp[records] = customer.getInfo();

                customers = new string[records];

                customers = temp;
            }
        }
        private static string getCustomerCount()
        {
            return $"Ilość zarejestrowanych klientów: {customers.Length}";
        }
        private static void getInfo()
        {
            Console.WriteLine("RAPORT BIURA\n---------------------");
            Console.WriteLine($"{getCustomerCount()}\n");

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer}\n");

            }
        }
    }
}
