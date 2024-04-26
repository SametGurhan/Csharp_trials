using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.@do.@while.döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {/*do
          {
          }while(şart);
          */
            //1den 10a kadar sayıları do while ile yazdır.
            /*  int a = 1;
              do
              {
                  Console.WriteLine(a);
                  a++;
              } while (a <= 10);
              */
            //1den 100e kadar olan sayıların toplamını yazdır

            int a = 1;
            int toplam = 0;
            do
            {
                toplam += a;
                a++;
            } while (a <= 100);
            Console.WriteLine("1'DEN 100'E KADAR OLAN SAYILARIN TOPLAMI:"+toplam);
            Console.ReadLine();









        }
    }
}
