using System;

namespace TestProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //interface kendi başına new lenemez. Soyut nesneler tek başına newlenemez.
            //IPerson person = new Customer();

            //InterfaceDemo();

            ICustomerDal[] customerDals = new ICustomerDal[2] {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };

            foreach (var customerdal in customerDals)
            {
                customerdal.Add();

            }

            Console.ReadLine();

        }

        private static void InterfaceDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            //interface örneği;
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Gamze",
                LastName = "Nur",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Can",
                LastName = "Nur",
                Department = "BTGM"
            };
            personManager.Add(customer);

            personManager.AddPerson(student);
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
                Console.WriteLine(person.FirstName);
            }


        }
    }
}
