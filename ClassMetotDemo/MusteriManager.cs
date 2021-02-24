using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi.." + musteri.Id +" "+ musteri.Adi+" "+musteri.Soyadi+" "+musteri.TcNo);
        }

        public void Sil(Musteri musteri)
        {
            Musteri[] musteriSil = new Musteri[]{ musteri };
            foreach (var mustSil in musteriSil)
            {
                Console.WriteLine("Müşteri Silindi!.. " + mustSil.Id +" "+ mustSil.Adi+" "+mustSil.Soyadi+" "+mustSil.TcNo);
            }
        }
        public void Listele(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] { musteri };
            foreach (var must in musteriler)
            {
                Console.WriteLine("Müşteri Listelendi.. " + must.Id + " "+ must.Adi+" "+must.Soyadi+" "+must.TcNo);
            }
        }
    }
}
