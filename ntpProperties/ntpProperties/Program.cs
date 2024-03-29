using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntpProperties
{
    class Product
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("name alanı zorunlu");
                }
            }
        }

        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                    _price = 0;
                else
                    _price = value;
            }
        }

        public bool IsApproved { get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product();
            p.Name = "Samsung";
            p.Price = 2000;

            Console.WriteLine(p.Price);
            Console.WriteLine(p.Name);

            Console.ReadKey();
        }
    }
}
