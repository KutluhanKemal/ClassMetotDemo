using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri: " + musteri.Id+ " "+ musteri.Ad+" "+ musteri.Soyad+" "+ musteri.Adres +"Müşteri Bilgileri Alındı. " );
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Adres + "Müşteri Bilgileri Silindi." );
        }

        public void MusteriListesi(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine("Müşteri Id:  " + musteri.Id);
                Console.WriteLine("Müşteri Adı:  " + musteri.Ad);
                Console.WriteLine("Müşteri Soyad:  " + musteri.Soyad);
                Console.WriteLine("Müşteri Adres:  " + musteri.Adres);
            }
        
        }
    }
}
