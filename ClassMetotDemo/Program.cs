using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "Kestane";
            musteri1.TcNo = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Gökhan";
            musteri2.Soyadi = "Kestane";
            musteri2.TcNo = "11111111111";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

        }
    }
}
