using System;

namespace TestProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Gamze",
                LastName = "Nur",
                Address = "Ankara"
            };
            personManager.Add(customer);

            personManager.AddPerson()
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }

        }
        class Student : IPerson
        {
            public int Id { get; set ; }
            public string FirstName { get; set ; }
            public string LastName { get ; set ; }
            public string Department { get; set; }

        }

        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName);
            }
            public void AddPerson(IPerson person)
            {
                Console.WriteLine(per.FirstName);
            }


        }
    }
}
