using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar.büyükküçük.örnek
{
    class Program
    {
        static void Main(string[] args)
        {//alınan 2 sayıyı karşılaştırma örneği
            Console.Write("Birinci sayiyi giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayiyi giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            kontrolet(sayi1, sayi2);
            Console.ReadLine();
        }
        static void kontrolet(int a,int b)
        {
            if(a>b)
            { Console.WriteLine("1.sayi ,2.sayidan büyüktür..."); }
            else if(a==b)
            { Console.WriteLine("1.sayi,2.sayiya eşittir..."); }
            else
            { Console.WriteLine("2.sayi,1.sayidan büyüktür..."); }

        }



    }
}
