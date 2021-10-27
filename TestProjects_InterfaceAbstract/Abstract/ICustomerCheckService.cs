using System;
using System.Collections.Generic;
using System.Text;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
