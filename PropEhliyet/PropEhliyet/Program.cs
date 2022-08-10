using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropEhliyet
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgiler alici = new Bilgiler();
            alici.isim = "Mert";
            alici.soyisim = "Berk";
            alici.yas = 22;
            alici.egitim = "üniversite";

            alici.kontrol();
            
            Console.ReadKey();

           
        }
    }
}
