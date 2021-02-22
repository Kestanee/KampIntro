using System;

namespace DENİYORUM
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarBugun = 7.45;
            double dolarDun = 7.45;
            bool sistemeGirisYapmismi = false;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }


            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine(i);
            }
            if (dolarBugun>dolarBugun)
            {
                Console.WriteLine("büyüktür");
            }
            else
            {
                Console.WriteLine("küçüktür");
            }

            string[] kurslar = new string[] { "java", "python", "furkan", "kestane" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
