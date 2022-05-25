using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : "+musteri.MusteriAd+" "+musteri.MusteriSoyad);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : "+musteri.MusteriAd+" "+musteri.MusteriSoyad);
        }
        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }
        public void MusterileriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri adı : " + musteri.MusteriAd);
            }
        }
        
    }
}
