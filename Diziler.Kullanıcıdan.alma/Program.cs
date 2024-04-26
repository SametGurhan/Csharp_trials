using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler.Kullanıcıdan.alma
{
    class Program
    {
        static void Main(string[] args)
        {//dizi elemanlarını kullanıcıdan alıp yazdırmak
            int[] sayilar = new int[4];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayilar dizisinin " + (i + 0) + ". index değerini giriniz:");
               
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("***********************************");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);

            }


            Console.ReadLine();

        }
    }
}

