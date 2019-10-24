using System;
namespace TravelOffice
{
    public class TravelOffice
    {

        static string[] customers;

        static void Main(string[] args)
        {

            Date start = new Date(2019, 11, 12);
            Date end = new Date(2019, 11, 30);

            Customer customer = new Customer("Pan Darek");

            Address address = new Address("Kuśnierska 4", "62-020", "Swarzędz");

            Trip trip = new Trip(start, end, "Poznań");

            customer.Address = address;
            customer.Trip = trip;

            //Console.WriteLine(customer.getInfo());

            addCustomer(customer);

            Console.WriteLine(customers[0]);
            Console.WriteLine(getCustomerCount());
        }

        private static void addCustomer(Customer customer)
        {

            customers = new string[1];
            customers[0] = customer.getInfo();
        }
        private static string getCustomerCount()
        {
            return $"\nIlość zarejestrowanych klientów: {customers.Length}";
        }

        private static string getInfo()
        {
            return $"";
        }
    }
}
