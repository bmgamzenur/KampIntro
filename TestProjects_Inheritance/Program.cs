using System;

namespace TestProjects_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{ FirstName="Gamze"},
                new Student{ FirstName = "Nur"},
                new Person{FirstName="Can"},
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Bir kişinin bir babası olur. 2 tane olamaz. 
    //Bir nesne bir kere inheritance alır fakat birden fazla implementasyon yapılabilir..
    //class Customer:Person,Person2 { } --> hatalıdır.
    //class Customer:Person, IPerson, IHuman olabilir. Inheritance önce yazılır.
    class Customer:Person
    {
        public string City { get; set; }

    }
    class Student:Person
    {
        public string Department { get; set; }

    }
}
