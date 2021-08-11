using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {


        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

        public void DoSmth(int num)
        {
            num = 99;
        }

        public void Test(Product product)
        {
            product.ProductName = "Kamera";
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1,int sayi2)
        {
            Console.WriteLine("sonuç: " + (sayi1+sayi2));
        }


    }
}
