using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.For.döngü.örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("___________________________");
                Console.WriteLine("Lütfen bir sayı giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int toplam = 0;
                for (int i = 1; i <= sayi; i++)
                {
                    toplam += i;

                }
                double ort = toplam / sayi;
                if (ort > 50)
                {
                    Console.WriteLine("Ortalamanız 50'den büyüktür.");
                }
                else
                {
                    Console.WriteLine("Ortalamanız 50'den küçüktür.");
                }
            }
            Console.ReadLine();
        }
    }
}
