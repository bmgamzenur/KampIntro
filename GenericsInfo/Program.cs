using GenericsIntro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("gamze");
           
            Console.WriteLine(isimler.Length);

            isimler.Add("ayşe");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);

            }
            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count());

        }

        
    }
}
