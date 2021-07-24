using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Murat";
            musteri1.SoyAdi = "Yıldırım";
            musteri1.DogumTarihi = 2002;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Çağrı";
            musteri2.SoyAdi = "Türkmen";
            musteri2.DogumTarihi = 2002;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Engin";
            musteri3.SoyAdi = "Demiroğ";
            musteri3.DogumTarihi = 1985;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManeger musteriManeger = new MusteriManeger();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Sil(musteri2);
            musteriManeger.Listele(musteriler);

        }
    }
}
