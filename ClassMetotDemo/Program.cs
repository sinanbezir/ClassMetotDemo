using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Name = "mehmet";
            musteri1.Surname = "yıldız";

            musteri2.Name = "selim";
            musteri2.Surname = "türk";

            musteri3.Name = "halis";
            musteri3.Surname = "çoban";

            Console.WriteLine("----- Müşteri Ekleme -----");
            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri1);
            musteriManager1.Ekle(musteri2);
            musteriManager1.Ekle(musteri3);

            Console.WriteLine("\n----- Müşteri Silme -----");

            musteriManager1.Sil(musteri1);

            Console.WriteLine("\n----- Müşteri Listeleme -----");

            Musteri[] musteriler=new Musteri[] { musteri1, musteri2,musteri3 };

            musteriManager1.Listele(musteriler);
        }
    }

}
    