using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"},

            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Acer Laptop ", QuantityPerUnit="32 GB", UnitPrice= 18000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1,ProductName="Asus Laptop ", QuantityPerUnit="16 GB", UnitPrice= 12000, UnitsInStock=2},              
                new Product{ProductId=3, CategoryId=1,ProductName="Hp Laptop ", QuantityPerUnit="8 GB", UnitPrice= 10000, UnitsInStock=4},
                new Product{ProductId=4, CategoryId=2,ProductName="Samsung Telefon ", QuantityPerUnit="4 GB", UnitPrice= 10000, UnitsInStock=2},
                new Product{ProductId=5, CategoryId=2,ProductName="Apple Telefon ", QuantityPerUnit="4 GB", UnitPrice= 8000, UnitsInStock=1},
            };

            Console.WriteLine("\nAlgoritmik-------------\n");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock >2)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("\nLINQ-------------\n");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 2);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }


        //LINQ ile yazılmadığı takdirde kod uzunluğu:
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> p = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock >2)
                {
                    p.Add(product);
                    //Console.WriteLine(product.ProductName);
                }
                
            }
            return p;
        }
        
        //Aynı kod - LINQ:
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 2).ToList();
        }

        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }
        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
