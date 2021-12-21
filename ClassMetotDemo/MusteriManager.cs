using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("Id : " + Musteri.Id);
                Console.WriteLine("Müşteri Adı : " + Musteri.Ad);
                Console.WriteLine("Müşteri Soyadı : " + Musteri.Soyad);
                Console.WriteLine("Mail Adresi : " + Musteri.Mail);
                Console.WriteLine("Müşteri Bilgileri Başarılı Şekilde Eklenmiştir. ");
                Console.WriteLine();
            }
        }

        public void Listele(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("Id : " + Musteri.Id);
                Console.WriteLine("Müşteri Adı : " + Musteri.Ad);
                Console.WriteLine("Müşteri Soyadı : " + Musteri.Soyad);
                Console.WriteLine("Mail Adresi : " + Musteri.Mail);
                Console.WriteLine("Müşteri Bilgileri Başarılı Şekilde Listelenmiştir. ");
                Console.WriteLine();
            }
        }

        public void Sil(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {

                Console.WriteLine("Id = " + Musteri.Id + " Müşteri Id li bilgiler Başarılı Şekilde Silinmiştir");
                Console.WriteLine();
            }
        }

        public void Guncelle(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("Id: " + Musteri.Id);
                Console.WriteLine("Müşteri Adı: " + Musteri.Ad);
                Console.WriteLine("Müşteri Soyadı: " + Musteri.Soyad);
                Console.WriteLine("Mail Adresi: " + Musteri.Mail);
                Console.WriteLine("Müşteri Bilgileri Başarılı Şekilde Güncellenmiştir. ");
                Console.WriteLine();
            }

        }

    }

}
