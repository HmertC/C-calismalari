using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hataexercice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var liste = new List<string>()
            //{
            //    "1","2","5a","10b","abc","10","50"
            //};

            //foreach (var item in liste)
            //{
            //    try
            //    {
            //        int a = int.Parse(item);
            //        Console.WriteLine(a);
            //    }
            //    catch (Exception)
            //    {
            //        continue;
            //    }

            //}

            //kullanıcı "q" değerini girmedikce her değerin sayısal olup olmadığını kontrol edin aksi halde hata gösterin

            //while (true)
            //{
            //    Console.Write("sayı : ");
            //    string input = Console.ReadLine();

            //    if (input == "q")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        int sayi = int.Parse(input);
            //        Console.WriteLine("girdiğiniz sayı {0}", sayi);
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("gecersiz sayı");
            //        continue;
            //    }

            //}

            // 3- Girilen parola içinde türkçe karakter araması

            Console.Write("parola : ");
            string parola = Console.ReadLine();

            try
            {
                CheckPassword(parola);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            
            }


            Console.ReadKey();
        }

        static void CheckPassword(string parola)
        {
            string turkce_karakter = "ğ,Ğ,ç,Ç,ş,Ş,ü,Ü,ö,Ö,ı,İ";

            foreach (var karakter in parola)
            {
                if (turkce_karakter.IndexOf(karakter)>-1)
                    throw new Exception("parola türkçe karakter içeremez");

            }
            Console.WriteLine("Geçerli parola");
        }
        
        
    }
}
