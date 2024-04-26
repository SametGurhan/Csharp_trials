using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tür.dönüsümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 5;// 500 yazarsan 254 değerini verir çünkü byte tipine dönüşünce 255e kadar tutabilir.
            byte b = (byte)a;
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();
            -byte dönüşümü yapıldı.
            _______________________________________
            string x = "1";
            string y = "2";
            //int a = int.Parse(x);
            //int b = int.Parse(y);
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);
            -int döüşümü yapıldı
            Console.WriteLine(a+b);
            _______________________________________
            
            int a = 5;
            int b = 10;
            string x = a.ToString();
            string y = b.ToString();
            Console.WriteLine(a+b);
            Console.WriteLine(x+y);
            -stringe dönüstürdüm
            */
            /*____________________________________ 
             double sayi = 5.22;
             // double sayi2=5.31;
             int a = Convert.ToInt32(sayi);
             //int b = int.Parse(sayi2); parse için ilk önce strig olması gerekir.
             Console.WriteLine(a);
             Console.WriteLine(sayi.GetType());
             Console.ReadLine();
            _______________________________________
            */
            //KULLANICIDAN ALINAN DEGERLER STRİNG OLUR.
            /*Console.WriteLine("Lütfen yaşınızı giriniz.");
            string kullanici_yas = Console.ReadLine();
            int kullanici_yasint = int.Parse(kullanici_yas);
            int kullanici_yasint2 = Convert.ToInt32(kullanici_yas);
            Console.WriteLine(kullanici_yasint);
            Console.WriteLine(kullanici_yasint2);
            ________________________________________
             */
            //---Kullanıcıdan 2 tane sayı alıp ikisinin toplamını ekrana yazdırın.

            Console.WriteLine("Lütfen 1.sayıyı giriniz.");
            string a = Console.ReadLine();
            
            Console.WriteLine("Lütfen 2.sayıyı giriniz.");
            string b = Console.ReadLine();
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            
            Console.WriteLine("iki sayının toplamı:" + (x+y));
            Console.ReadLine();
            //ToString();
            //Convert.ToInt32();
            //int.parse();
            //double.parse();
            //(int)
         
        }
    }
}
