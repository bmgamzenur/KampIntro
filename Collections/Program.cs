using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //array belirlenen sınırlar içinde hareket eder. bu yüzden array yerine koleksiyon kullanırız.
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            //isimler = new string[5];
            //isimler[4] = "gamze";
            //console.writeline(isimler[1]);


            List<string> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };

            isimler2.Add("gamze");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            
        }
    }
}
