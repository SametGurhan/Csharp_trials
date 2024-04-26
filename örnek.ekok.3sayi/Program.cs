using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek.ekok._3sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            char devam;
            do
            {
                Console.WriteLine("lütfen ekoku alınacak 2 sayı giriniz");

                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                i = 1;
            a1:

                if (i % a == 0 && i % b == 0)
                {
                    Console.WriteLine("ekok=" + i);
                }
                else
                {
                    i += 1;
                    goto a1;
                }

                Console.WriteLine("Devam için d bas");
                
                devam = Convert.ToChar(Console.ReadLine());


            }
            while (devam == 'd' || devam == 'D');
            
            Console.ReadLine();

        }
    }
}
