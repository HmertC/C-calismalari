using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnriclist
{

    class Product
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();

            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);

            List<string> isimler = new List<string>();
            isimler.Add("Ali");
            isimler.Add("ahmet");
            isimler.Add("mehmet");

            List<Product> urunler1 = new List<Product>()
            {
                new Product(){Name = "Samsung m51" },
                new Product(){Name = "Samsung m52" },
                new Product(){ Name = "Samsung m53"},
                new Product(){ Name = "Samsung m54"}
            };


            List<Product> urunler2 = new List<Product>()
            {
                new Product(){Name = "Iphone m51"},
                new Product(){Name = "Iphone m52"},
                new Product(){Name ="Iphone m53"},
                new Product(){Name = "Iphone m54"}
            };

            //urunler1.AddRange(urunler2);

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //foreach (var urun in urunler1)
            //{
            //    Console.WriteLine(urun.Name);
            //}

            //urunler1.ForEach(p => {
            //    Console.WriteLine(p.Name);
            //    });

            //int count = urunler1.Count;

            //Console.WriteLine(count);

            //Console.WriteLine(urunler2[0].Name);

            //for (int i = 0; i < urunler2.Count ; i++)
            //{
            //    Console.WriteLine(urunler2[i].Name);
            //}

            sayilar.Insert(1, 100);

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            urunler1.InsertRange(1, urunler2);

            for (int i = 0; i < urunler1.Count; i++)
            {
                Console.WriteLine(urunler1[i].Name);
            }

            Console.ReadKey();

          
        }
    }
}
