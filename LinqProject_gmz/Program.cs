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
                new Category{CategoryId=1,CategoryName="Linux"},
                new Category{CategoryId=2,CategoryName="Windows"},
                new Category{CategoryId=3,CategoryName="Apple"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Lenovo", QuantityPerUnit="32 GB RAM",UnitInStock=5,UnitPrice=8000},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus", QuantityPerUnit="16 GB RAM",UnitInStock=8,UnitPrice=10000},
                new Product{ProductId=3,CategoryId=2,ProductName="Hp", QuantityPerUnit="8 GB RAM",UnitInStock=10,UnitPrice=13000},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung", QuantityPerUnit="64 GB RAM",UnitInStock=3,UnitPrice=8000},
                new Product{ProductId=5,CategoryId=3,ProductName="Mac", QuantityPerUnit="32 GB RAM",UnitInStock=2,UnitPrice=25000},
            };

            //FirstLinqMetod(products);

            //AnyTestMetod(products);

            //FindTestMetod(products);

            //FindAllTestMetod(products);

            //AscDscTestMetod(products);

            //FromSelectMetod(products);

            //ClassicLinqMetod(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 8000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId,CategoryName=c.CategoryName,ProductName=p.ProductName,UnitPrice=p.UnitPrice};

            foreach (var item in result)
            {
                //Console.WriteLine(item.ProductName + " bilgisyarın sistemi: " + item.CategoryName);
                Console.WriteLine("{0} ---- {1}", item.ProductName,item.CategoryName);
            }

        }

        private static void ClassicLinqMetod(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 9000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FromSelectMetod(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 9000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        //Single Line Query Examples:
        private static void AscDscTestMetod(List<Product> products)
        {
            var result = products.Where(p => p.QuantityPerUnit.Contains("RAM")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);

            }
        }

        private static void FindAllTestMetod(List<Product> products)
        {
            //findAll: şarta uyan bütün elemanları getirir.liste döner. where koşulu gibidir. contains: RAM içerenleri getirir. 
            //bunun yerine genellikle where kullanılır.
            var result = products.FindAll(p => p.QuantityPerUnit.Contains("RAM"));
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindTestMetod(List<Product> products)
        {
            //aradığınız kritere uygun nesnenin kendisini döner. bir ürünün(nesnenin) detayına ulaşmak için kullanırız.
            var result = products.Find(p => p.ProductId == 8);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTestMetod(List<Product> products)
        {
            //Any: bir listenin içinde bir eleman var mı yok mu true/false döner.
            var result = products.Any(p => p.ProductName == "Lenovo");
            Console.WriteLine(result);
        }

        private static void FirstLinqMetod(List<Product> products)
        {
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

    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int UnitPrice { get; set; }
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
