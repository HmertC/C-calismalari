using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(derinlik(13));
            Console.ReadKey();
        }
        public static int derinlik (int derin)
        {
            int a = 1;
            int b = 1;
            int c;

            int[] fib = new int[derin];

            fib[0] = 1;
            fib[1] = 1;

            for (int i = 2; i < derin; i++)
            {
                c = a + b;
                fib[i] = c;
                a = b;
                b = c;
                
            }
            int toplam = 0;
            foreach (var item in fib)
            {
                toplam += item;
            }
            int ortalama = toplam / derin;

            foreach (var item in fib)
            {
                Console.WriteLine(item);
            }

            return ortalama;
           
        }
        
    }
}
