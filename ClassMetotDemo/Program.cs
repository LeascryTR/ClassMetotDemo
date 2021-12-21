using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Emirhan";
            musteri1.Soyad = "Dönmez";
            musteri1.Mail = "ed@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Ad = "Oguzgan";
            musteri2.Soyad = "Dönmez";
            musteri2.Mail = "od@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1;
            musteri3.Ad = "Engin";
            musteri3.Soyad = "Demiroğ";
            musteri3.Mail = "ed1@gmail.com";

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager Musteri = new MusteriManager();
            Musteri.Ekle(Musteriler);
            Musteri.Listele(Musteriler);
            Musteri.Sil(Musteriler);
            Musteri.Guncelle(Musteriler);

        }
    }
}
