using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Buğrahan", LastName="Gökçe" };

            Customer customer2 = new Customer();
            customer2.Id = 2;

            Customer customer3 = new Customer(2, "Emir", "Gökçe");

            Console.WriteLine(customer3.Id);

            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
