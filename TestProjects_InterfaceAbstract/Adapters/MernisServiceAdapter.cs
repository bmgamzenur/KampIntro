
using MernisServiceReference;
using System;
using TestProjects_InterfaceAbstract.Abstract;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            Console.WriteLine(client);
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper, customer.LastName.ToUpper, customer.DateofBirth.Year);
        }
    }
}
