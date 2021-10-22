using System;

namespace TestProjects_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çalışan array oluşturmak istiyorum. Bu hepsini çalıştırmak istiyorum.
            IWorker[] workers = new IWorker[2]
            {
                new Personel(),
                new Robot(),
            };
            foreach (var worker in workers)
            {
                worker.Work();

            }

            //Personel maaş alsın.
            IHuman[] humen = new IHuman[1]
            {
                new Personel()
            };

            foreach (var person in humen)
            {
                person.GetSalary();

            }

        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IHuman
    {
        void Eat();
        void GetSalary();
    }

    class Personel : IWorker, IHuman
    {
        public void Eat()
        {
            Console.WriteLine("Personel Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Personel Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Personel Work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }


}
