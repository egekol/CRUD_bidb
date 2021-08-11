using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            MyList<string> isimler = new MyList<string>();
            Console.WriteLine("isimler list: " + isimler);
            isimler.Add("Ege");
            Console.WriteLine("new isimler list: " + isimler.Length);

            isimler.Add("Efe");
            Console.WriteLine("new isimler list: " + isimler.Length);

            Console.WriteLine(isimler.Items[1]);

        }


    }
}
