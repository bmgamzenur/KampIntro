using System;

namespace TestProjects_InterfaceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface ler onu implemente eden class ın referansını tutabilirler.
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Update();

            IPersonManager customerManager = new CustomerManager();
            //projectManager içerisine tek başına IPersonManager gönderemeyiz
            //fakat referansını tutumuş bir IPersonManager yani customerManager gönderebiliyorum.
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            //Mevcut koduma dokunmadan. stajyer ekleyebilmek için class InternManager ekledim.
            //Bunu da projectManager direkt olarak gönderebiliyorum.
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager
    {
        //unimplemented operation: default public tir.
        void Add();
        void Update();  
    }
    // class - inherits -------------- interface - implements yapılmış olur.
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi.");
        }
    }
    class ProjectManager
    {
        //parametresi interface. Hem customer hem employee ekleyebilmek istiyorum.
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
