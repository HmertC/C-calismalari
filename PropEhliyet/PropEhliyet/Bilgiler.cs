using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropEhliyet
{
    class Bilgiler
    {
        public string isim;
        public string soyisim;
        public int yas;
        public string egitim;

        public void yazdir()
        {
            Console.WriteLine("İsminiz : "+isim);
            Console.WriteLine("Soyisminiz : "+soyisim);
            Console.WriteLine("Yaşınız : "+yas);
            Console.WriteLine("Eğitim Durumunuz : "+egitim);
        }

        public void kontrol()
        {
            if (yas >= 18 && (egitim =="lise" || egitim == "üniversite"))
            {
                Console.WriteLine("Sayın " + isim +" " + soyisim + " Ehliyet alabilirsiniz");
            }
            else
            {
                Console.WriteLine("Ehliyet Alamazsınız");
            }
        }

    }
}
