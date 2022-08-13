using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Customer customer1 = new Customer();
            Employee employee1 = new Employee();

            Person person2 = customer1;
            customer1.FirstName = "Buğrahan";
            Console.WriteLine(person2.FirstName);

            customer1.CreditCartNumber = "Number";

            employee1.LastName = "Gökçe";

            Person person3 = new Person();
            //Olmuyor - Customer customer2 = person3;

            Console.WriteLine(((Customer)person2).CreditCartNumber);


            PersonManager personManager = new PersonManager();
            personManager.Add(employee1);

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCartNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeId { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.LastName);
        }
    }
}

