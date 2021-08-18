using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dört İşlem Yapma");

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
        }
    }
}
