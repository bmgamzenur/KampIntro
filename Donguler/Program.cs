using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array - Dizi
            string[] kurslar = new string[] {"Java","c#","pyton","android"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("For Ending..");

            foreach (string kurs in kurslar)
            {   
                //foreach ile dizinin elemanlarını tek tek dolaşıp işlem yapıyor. 
                Console.WriteLine(kurs);
            }
            //for daha genel amaçlı kullanılırken foreach dizileri dolaşmak için kullanılır.

            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}
