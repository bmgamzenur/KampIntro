using System;

namespace MyTestingProject_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.UrunAdi = "Bilgisayar";
            Urun1.UrunMarkasi = "Lenova";
            Urun1.UrunFiyati = "5000";

            Urun Urun2 = new Urun();
            Urun2.UrunAdi = "Telefon";
            Urun2.UrunMarkasi = "Samsung";
            Urun2.UrunFiyati = "3500";

            Urun Urun3 = new Urun();
            Urun3.UrunAdi = "Televizyon";
            Urun3.UrunMarkasi = "Beko";
            Urun3.UrunFiyati = "7000";

            Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3 };

            foreach (var urun in Urunler)
            {
                Console.WriteLine(urun.UrunAdi + ":" + urun.UrunMarkasi + "-" + urun.UrunFiyati);
            }
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }
        public string UrunFiyati { get; set; }
    }
}
