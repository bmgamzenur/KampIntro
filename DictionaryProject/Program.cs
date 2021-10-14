using System;
using System.Collections.Generic;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<String, int> AdYas = new Dictionary<string,int>();

            SortedDictionary<String, int> AdYas = new SortedDictionary<string, int>();
            AdYas.Add("Gamze", 30);
            AdYas.Add("Ayşe", 29);
            AdYas.Add("Nur", 33);
            AdYas.Add("Can", 38);
            Console.WriteLine("------------------Eski Liste");

            foreach (var kisi in AdYas)
            {
                Console.WriteLine(kisi);

            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Toplam Kişi sayısı: " + AdYas.Count);

            AdYas.Remove("Can");
            Console.WriteLine("------------------Yeni Liste");
            foreach (var kisi in AdYas)
            {
                
                Console.WriteLine(kisi);

            }

        }
    }
}
