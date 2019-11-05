using System;
using System.Text;

namespace TravelOffice
{
    public class TravelOffice
    {
        static string[] customers = new string[1];

        public TravelOffice() {

            Console.WriteLine("Biuro podróży utworzone :)");

        }

        public void AddCustomer(Customer customer)
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
        public void getCustomerCount()
        {
            Console.WriteLine($"Ilość zarejestrowanych klientów: {customers.Length}");
        }
        public string getInfo()
        {
            StringBuilder stringB = new StringBuilder();

            stringB.Append("RAPORT BIURA\n---------------------");
            stringB.Append($"\nIlość zarejestrowanych klientów: {customers.Length}\n\n");
                       
            foreach (string customer in customers)
            {
                stringB.Append($"{customer}\n");

            }
            return stringB.ToString();
        }
               
    }
}
