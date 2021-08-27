using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //CRUD : create read update delete operasyonları.
        //Ürün ile ilgili operasyonlar genel olarak burada bulunur.
        //Encapsulation yaparak tek tek ürün özelliklerini yazmak yerine, product class oluşturup ondan üretim yapıyoruz. (Product product)
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        { 
            Console.WriteLine(product.ProductName + " güncellendi.");

        }


    }
}
