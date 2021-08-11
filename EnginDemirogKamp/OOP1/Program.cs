using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 599.99;
            product1.UnitsInStock = 4;
            //----------------------------------

            Product product2 = new Product
            { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 39.99 };

            ProductManager productManager = new ProductManager();

            productManager.Test(product1);


            //Mantığı kavramak için küçük bir test. Burada oluşturulan int sayı
            //ProductManager classındaki metodun içine yollandı ve çalıştırıldı(diğer sekmeden kontrol et).
            //Sayının değeri değiştirildi. Konsolda hangi sayı çıkacak?
            int sayi = 100;
            productManager.DoSmth(sayi);
            Console.WriteLine(sayi);

            //product'ın ismi diğer classta değiştirildi, konsolda hangi isim çıkacak?
            Console.WriteLine(product1.ProductName);

            //int, double, bool vs. tipler değer tipidir.
            //array, class, interface vs. tipler ise referans tipidir. Stack'te yazılan yeni değerin bilgisini "heap" üzerinde
            //eski değer üzerinden alıp almadığına bağlı olarak değişir
            //------------------------
            //method oluştururken void kullanılmasının sebebi nedir?
            //Örnek için "Topla" ve "Topla2" metodları:

            productManager.Topla2(3, 9);

            int toplamiCagir = productManager.Topla(3, 9);
            Console.WriteLine("Ek işlem: " + toplamiCagir *2);


        }

    }
}
