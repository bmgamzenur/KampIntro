using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", IdentityNumber = 12345, LastName = "DEMİROG" });

            Console.WriteLine("Hello World!");
        }
    }
}
