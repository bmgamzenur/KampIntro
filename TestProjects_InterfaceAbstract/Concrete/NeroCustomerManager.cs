using System;
using System.Collections.Generic;
using System.Text;
using TestProjects_InterfaceAbstract.Abstract;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
