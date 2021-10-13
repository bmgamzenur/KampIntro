using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                Adi = "Gamze",
                Soyadi = "Nur",
                Adresi = "Ankara",
            };
            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Adi = "Ayşe",
                Soyadi = "Can",
                Adresi = "İstanbul",
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.GetAllMusteri();
        }
    }
}
