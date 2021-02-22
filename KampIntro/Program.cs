using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // string kurs3 = "yazılım";
          //  string kurs1 = "bilgisayar";
            // kurs2 = "data";

          /*  string[] kurslar = new string[] {"yazılım","bilgisayar","data" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }*/

            Console.WriteLine("---------------------------------------------------");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 88;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "engin";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "engin";
            kurs3.IzlenmeOrani = 88;

            //Console.WriteLine(kurs1.KursAdi+ " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : "+ kurs.Egitmen);
            }

        }
    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}