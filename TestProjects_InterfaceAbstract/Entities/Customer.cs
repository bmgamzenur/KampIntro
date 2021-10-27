using System;
using TestProjects_InterfaceAbstract.Abstract;

namespace TestProjects_InterfaceAbstract.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityId { get; set; }

    }
}
