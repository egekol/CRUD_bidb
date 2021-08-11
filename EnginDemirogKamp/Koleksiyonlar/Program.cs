using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Ali", "Necati" };
            Console.WriteLine("İsim1 :" + isimler[0]);


            //isimler[3] = "Ege";
            //Console.WriteLine(isimler[3]);
            //hata verir

            isimler = new string[5];
            //artık eski isimlerdeki isimlerin hepsi silinmiş oldu
            Console.WriteLine("İsim1 :" + isimler[0]);

            Console.WriteLine("-------------------------------------");

            List<string> isimler2 = new List<string>() { "Engin", "Ali", "Necati" };
            Console.WriteLine("İsim1 :" + isimler[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);




        }
    }
}
