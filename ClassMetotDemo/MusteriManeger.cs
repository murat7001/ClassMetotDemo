using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManeger
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:" + " " + musteri.Adi +" "+ musteri.SoyAdi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :" + " " + musteri.Adi +" "+ musteri.SoyAdi);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi+" "+musteri.SoyAdi);
            }
        }
    }
}
