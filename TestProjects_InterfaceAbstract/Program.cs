
using System;
using TestProjects_InterfaceAbstract.Abstract;
using TestProjects_InterfaceAbstract.Adapters;
using TestProjects_InterfaceAbstract.Concrete;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract
{
    //STARBUCKS & NERO UYGULAMASI
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                NationalityId = "26617504304",
                FirstName = "Gamze Nur",
                LastName = "Akkaş",
                DateofBirth = new DateTime(1991, 2, 14),
            });
            Console.ReadLine();
        }
    }
}
