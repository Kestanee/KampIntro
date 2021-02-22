using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 64;
            kurs1.KursAdi = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmeni = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 64;
            kurs2.KursAdi = "Java";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmeni = "Kerem Varış";
            kurs3.IzlenmeOrani = 64;
            kurs3.KursAdi = "Python";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}