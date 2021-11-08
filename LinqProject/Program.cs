using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
           {
               new Category{CategoryId=1,CategoryName="Bilgisayar"},
               new Category{CategoryId=2,CategoryName="Telefon"},
           };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2, CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=3, CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=4, CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ProductId=5, CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1 }
            };

            Console.WriteLine("Algoritmik Çözüm-----------------");

            foreach (var p in products)
            {
                if (p.UnitPrice > 1000 && p.UnitsInStock < 5)
                {
                    Console.WriteLine(p.ProductName);
                }

            }

            Console.WriteLine("Linq Çözümü------------------");
            var result = products.Where(p => p.UnitPrice > 1000 && p.UnitsInStock < 5);

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }

            GetProducts(products);

        }

        //Algoritmik Çözüm
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var p in products)
            {
                if (p.UnitPrice > 1000 && p.UnitsInStock < 5)
                {
                    filteredProducts.Add(p);
                }
            }
            return filteredProducts;
        }

        //Linq Çözüm
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 1000 && p.UnitsInStock < 5).ToList();
        }


        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public short UnitsInStock { get; set; }
            public int UnitPrice { get; set; }

        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
