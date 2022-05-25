using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.MusteriTC = "12345678912";
            musteri1.MusteriAd = "Ayşe";
            musteri1.MusteriSoyad = "Çelik";

            musteri2.MusteriId = 2;
            musteri2.MusteriTC = "12345678914";
            musteri2.MusteriAd = "Bora";
            musteri2.MusteriSoyad = "Yıldırım";

            musteri3.MusteriId = 3;
            musteri3.MusteriTC = "12345678916";
            musteri3.MusteriAd = "Gizem";
            musteri3.MusteriSoyad = "Kaya";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriGuncelle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            musteriManager.MusterileriListele(musteriler);



        }
    }
}
