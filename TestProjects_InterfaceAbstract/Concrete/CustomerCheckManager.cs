using System;
using System.Collections.Generic;
using System.Text;
using TestProjects_InterfaceAbstract.Abstract;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
        //Bu şekilde kullanım sağlarsak mernis servisi çalışmadığı durumlarda sıkıntı yaşarız.
        //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return true;
        }
    }
}
