using System;
using System.Text;

namespace TravelOffice
{
    public class TravelOffice
    {
        private Customer[] _customers = new Customer[1];

        public TravelOffice() {

            Console.WriteLine("Biuro podróży utworzone :)");

        }
        public Customer[] Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        public int CustomerCount => _customers.Length;


        public void AddCustomer(Customer customer)
        {

            if (_customers[0] == null)
            {
                _customers[0] = customer;
            }
            else
            {
                int records = _customers.Length;

                Customer[] temp = new Customer[records + 1];
                _customers.CopyTo(temp, 0);

                temp[records] = customer;

                _customers = new Customer[records];

                _customers = temp;
            }
        }
        public void ClearCustomers()
        {
            Array.Clear(_customers, 0, CustomerCount);
            _customers = new Customer[1];
        }
        
        public string getInfo()
        {
            StringBuilder stringB = new StringBuilder();

            int customerCount = CustomerCount;
            if (_customers[0] == null)
            {
                customerCount = 0;
            }

            stringB.Append("RAPORT BIURA\n---------------------");
            stringB.Append($"\nIlość zarejestrowanych klientów: {customerCount}\n\n");
                       
            foreach (var customer in _customers)
            {
                stringB.Append($"{customer}\n");

            }
            return stringB.ToString();
        }
               
    }
}
