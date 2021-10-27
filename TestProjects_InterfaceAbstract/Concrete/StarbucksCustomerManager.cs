using System;
using System.Collections.Generic;
using System.Text;
using TestProjects_InterfaceAbstract.Abstract;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //Mernis kontrolünü yaptırıp standart kaydımızı base den yaptırabiliriz.

            //CheckIfRealPerson(customer);
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        //private void CheckIfRealPerson(Customer customer)
        //{
        //    //Mernise buradan bağlanıp bütün kodu yazabilirim.Bunun yerine interface oluşturdum. 'ICustomerCheckService'
        //}
    }
}
