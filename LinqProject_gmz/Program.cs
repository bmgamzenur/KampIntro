using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject_gmz
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
                new Product{ProductId=1,CategoryId=1,ProductName="Lenovo", QuantityPerUnit="32 GB RAM",UnitInStock=5,UnitPrice=10000},
                new Product{ProductId=1,CategoryId=1,ProductName="Asus", QuantityPerUnit="16 GB RAM",UnitInStock=8,UnitPrice=8000},
                new Product{ProductId=1,CategoryId=1,ProductName="Hp", QuantityPerUnit="8 GB RAM",UnitInStock=10,UnitPrice=13000},
                new Product{ProductId=1,CategoryId=1,ProductName="Samsung", QuantityPerUnit="64 GB RAM",UnitInStock=3,UnitPrice=11000},
                new Product{ProductId=1,CategoryId=1,ProductName="Mac", QuantityPerUnit="32 GB RAM",UnitInStock=2,UnitPrice=25000},
            };

            //var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            //foreach (var p in result)
            //{
            //    Console.WriteLine(p.ProductName);
            //}
            List<Product> filteredProduct = GetProducts(products);
            foreach (var p in filteredProduct)
            {
                Console.WriteLine(p.ProductName);
            }
            
        }
        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitInStock { get; set; }
        public int UnitPrice { get; set; }

    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
