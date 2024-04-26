using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot.ama.parametrelisi
{
    class Program
    {
        static void Main(string[] args)
        {//parametreli metot tanımlama
            toplamayap(10, 21);//kısayolla tanımlama yaptım
            carpmayap(5, 5);
            isimsoyisimyazdır("Samet", "Gürhan");
            //Console.WriteLine(topla(5, 4, 2, 3)); 
            Console.ReadLine();
        }

        static void toplamayap(/*veri tipi şart*/int sayi1, int sayi2)
        {
            Console.WriteLine("Girilen sayıların toplamı:" + (sayi1 + sayi2));
        }
        static void carpmayap(int sayi1, int sayi2)
        {
            Console.WriteLine("Girilen sayilarin çarpımı:" + (sayi1 * sayi2));
            Console.ReadLine();
        }
        static void isimsoyisimyazdır(string isim, string soyisim)
        {
            Console.WriteLine("İsim ve soyisim:" + isim + " " + soyisim);
        }

        //static int topla(params int[] numbers)
        //{
        //    istediginin kadarsayi toplatabilir
        //    return numbers.Sum();
        //}


    }
}
