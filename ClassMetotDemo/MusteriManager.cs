using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri[] musteriler)
        {
            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Ünsal";
            musteri4.Soyad = "KARASU";
            musteri4.Yas = 28;
            musteri4.Aciklama = "Mühendis";
            musteriler[2] = musteri4;
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                if(musteri!=null)
                {
                    Console.WriteLine("Müsteri Ad Soyad : " + musteri.Ad + " " + musteri.Soyad);
                    Console.WriteLine("Yaş : " + musteri.Yas);
                    Console.WriteLine("Açıklama " + musteri.Aciklama);
                    Console.WriteLine("-----------------------------");
                }
            }
        }
        public void MusteriSil(Musteri[] musteriler)
        {
            Array.Clear(musteriler, 1, 2);
            Console.WriteLine("Müşteriler Silindi.");
        }
    }
}
