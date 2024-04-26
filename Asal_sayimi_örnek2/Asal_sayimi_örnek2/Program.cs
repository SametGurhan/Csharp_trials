using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_sayimi_örnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool sonuc;
                int sayac = 0;
                for (int i = 1; i <= sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac += 1;
                    }

                }//sayı kendine bölünene kadar dönüyor.
                if (sayac == 2) //sayaç 2de durursa:
                { sonuc = true; }
                 else sonuc = false;
        
                if (sonuc==true) Console.WriteLine("Asal Sayı");
                else Console.WriteLine("asal sayı değil");

            Console.ReadLine();

        }
    }
}
