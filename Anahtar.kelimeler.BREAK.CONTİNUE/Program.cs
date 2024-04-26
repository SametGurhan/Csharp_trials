using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anahtar.kelimeler.BREAK.CONTİNUE
{
    class Program
    {
        static void Main(string[] args)
        {//BREAK VE CONTINUE
            /* for (int a=1;a<=10;a++)
             {
                 if (a==7)
                 {
                     break;//7ye dönünce döngüyü kıracak.
                 }
                 Console.WriteLine("a'nın değeri:"+a);
             }
             */
            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue;//1 kere kırıyor 7de
                }
                Console.WriteLine("a'nın değeri:" + a);
            }
            
            Console.ReadLine();



        }
    }
}
