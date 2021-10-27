using System;
using System.Collections.Generic;
using System.Text;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
