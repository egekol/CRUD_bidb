using System;

namespace EnginDemirogKamp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.IzlenmeOrani = 68;
            kurs1.KursAdi = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.IzlenmeOrani = 40;
            kurs2.KursAdi = "Java";

            Kurs kurs3 = new Kurs();
            kurs3.IzlenmeOrani = 80;
            kurs3.KursAdi = "Python";

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }

        public int IzlenmeOrani { get; set; }
        

    }
}
