using System;
using System.Collections.Generic;
using System.Text;
using TestProjects_InterfaceAbstract.Entities;

namespace TestProjects_InterfaceAbstract.Abstract
{
    //Base Interface
    public interface ICustomerService
    {
        //2 firmada da müşteri kayıt etme var.interface ile soyutlama yaparak.Yeni bir firma eklemesinde daha kolay olur.
        void Save(Customer customer);
    }
}
