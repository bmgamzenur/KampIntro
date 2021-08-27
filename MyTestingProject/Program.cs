using System;

namespace MyTestingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            TERNARY OPERATORU:

            Console.WriteLine("Lütfen bir sayı giriniz:");
            bool isEven;
            int number;
            number = int.Parse( Console.ReadLine());
            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);
         */
            /*SWITCH YAPISI**/
            Console.WriteLine("BUGÜN GÜNLERDEN NE?");
            string myDay = Console.ReadLine();

            switch (myDay)
            {
                case "Pazartesi":
                    Console.WriteLine("Pazartesi Sendromu :( ");
                    break;
                case "Salı":
                    Console.WriteLine("Haftasonuna 3gün kaldı");
                    break;
                case "Çarşamba":
                    Console.WriteLine("Haftasonuna 2gün kaldı");
                    break;
                case "Perşembe":
                    Console.WriteLine("Haftasonuna 1gün kaldı");
                    break;
                case "Cuma":
                    Console.WriteLine("Tebrikler yarın tatil");
                    break;
                case "Cumartesi":
                    Console.WriteLine("En Sevdiğim Gün :) ");
                    break;
                case "Pazar":
                    Console.WriteLine("Yarın İş Başı");
                    break;
                default:
                    Console.WriteLine("Dikkat! Yazım Hatası Yapıyorsunuz.");
                    break;
            }

        }
    }
}
