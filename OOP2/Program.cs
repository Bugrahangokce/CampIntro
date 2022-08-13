using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNumber = "12345";
            individualCustomer1.FirstName = "Buğrahan";
            individualCustomer1.LastName = "Gökçe";
            individualCustomer1.TcNumber = "1234567890";

            //Kodlama.io

            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 2;
            corporateCustomer1.CustomerNumber = "54321";
            corporateCustomer1.CompanyName = "Kodlama.io";
            corporateCustomer1.TaxNumber = "1234567890";

            Customer customer1 = new Customer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            Console.ReadLine();
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID
        }
    }
}
