using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StaticApp
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }

    static class ProductManager
    {
        static Product[] Products;

        static ProductManager()
        {
            Products = new Product[5];

            Products[0] = new Product { ProductId = 1, ProductName = "Samsung M51", Price = 12000, IsApproved = false };
            Products[1] = new Product { ProductId = 2, ProductName = "Samsung M52", Price = 11000, IsApproved = false };
            Products[2] = new Product { ProductId = 3, ProductName = "Samsung M53", Price = 10000, IsApproved = true };
            Products[3] = new Product { ProductId = 4, ProductName = "Samsung M54", Price = 9000, IsApproved = true };
            Products[4] = new Product { ProductId = 5, ProductName = "Samsung M55", Price = 15000, IsApproved = true };
        }

        public static Product[] GetProducts()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if (p.ProductId == id)
                {
                    product = p;
                    break;
                }
            }

            return product;
        }

        public static Product GetProductByName(string name)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if (p.ProductName.Contains(name.ToLower()))
                {
                    product = p;
                    break;
                }
                    
            }
            return product;
        }
            

    }

    class Program
    {
        static void Main(string[] args)
        {


            //var product = ProductManager.GetProductById(4);
            //Console.WriteLine($"name : {product.ProductName} price : {product.Price}");

            //var products = ProductManeger.GetProducts();
            //foreach (var p in products)
            //{
            //    Console.WriteLine($"name : {p.ProductName} price : {p.Price}");

            //   
            //}

            var product = ProductManager.GetProductByName("ams");
            Console.WriteLine($"name : {product.ProductName} price : {product.Price}");

            Console.ReadKey();
        }
    }
}
