using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                MusteriManager musteriManager = new MusteriManager();
                Musteri musteri1 = new Musteri();
                musteri1.Ad = "Ali";
                musteri1.Soyad = "ATALAY";
                musteri1.Yas = 27;
                musteri1.Aciklama = "Öğrenci";

                Musteri musteri2 = new Musteri();
                musteri2.Ad = "Burcu";
                musteri2.Soyad = "AKEL";
                musteri2.Yas = 30;
                musteri2.Aciklama = "Okul Öncesi Öğretmeni";

                Musteri musteri3 = new Musteri();
                musteri3.Ad = "Hüseyin";
                musteri3.Soyad = "ATALAY";
                musteri3.Yas = 33;
                musteri3.Aciklama = "Sosyal Bilgiler Öğretmeni";

                Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


                //Müşteri Listeleme

                musteriManager.MusteriListele(musteriler);
                //Müşteri Listeleme
                // Müşteri Ekle
                musteriManager.MusteriEkle(musteriler);
                Console.WriteLine("Müşteri Eklendi");
                musteriManager.MusteriListele(musteriler);
                //Müşteri Ekle

                //Müşteri Silme
                musteriManager.MusteriSil(musteriler);
                //Müşteri Silme

                //Dizideki müşteri silindikten sonra Müşteri Listeleme
                Console.WriteLine("Dizideki müşteri silindikten sonra Müşteri Listeleme");
                musteriManager.MusteriListele(musteriler);
                //Dizideki müşteri silindikten sonra Müşteri Listeleme
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
