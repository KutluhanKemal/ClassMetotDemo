using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000;
            musteri1.Ad = " Kemal ";
            musteri1.Soyad = " Yazıcıoğlu ";
            musteri1.Adres = " IST/Turkey ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1000;
            musteri2.Ad = " Kutluhan ";
            musteri2.Soyad = " Yazıcıoğlu ";
            musteri2.Adres = " IST/Turkey ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1000;
            musteri3.Ad = " Burak ";
            musteri3.Soyad = " Yazıcıoğlu ";
            musteri3.Adres = " IST/Turkey ";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1000;
            musteri4.Ad = " Burcu ";
            musteri4.Soyad = " Yazıcıoğlu ";
            musteri4.Adres = " IST/Turkey ";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 1000;
            musteri5.Ad = " İsmail ";
            musteri5.Soyad = " Yazıcıoğlu ";
            musteri5.Adres = " IST/Turkey ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("\nMüşteri Ekle: \n");

            foreach (var musteri in musteriler)
            {
                Console.Write("Müşteri Bilgileri: ");
                musteriManager.MusteriEkle(musteri);
            }



            Console.WriteLine("\nMüşteri Sil: \n");

            foreach (var musteri in musteriler)
            {
                Console.Write("Müşteri Bilgileri: ");
                musteriManager.MusteriSil(musteri);
            }

            Console.WriteLine("\nMüşteri Listesi: \n");

           
            musteriManager.MusteriListesi(musteriler);



        }
    }
}
