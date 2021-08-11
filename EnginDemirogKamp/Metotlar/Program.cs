using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 25;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Fiyati);
            }

            Console.WriteLine("----------------------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun2);

            sepetManager.Ekle(urun1);

        }
    }
}
