using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar.tekmiçiftmi.örnek
{
    class Program
    {
        static void Main(string[] args)
        {//alınan sayı çift mi tek mi yazdır.
            Console.Write("bir sayı girin:");
            int girilensayi = int.Parse(Console.ReadLine());
            tekmiciftmi(girilensayi);
             Console.ReadLine();

        }
        static void tekmiciftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çift.");
            }
            else
            {
                Console.WriteLine("Sayi tektir.");
            }

        }


    }
}
