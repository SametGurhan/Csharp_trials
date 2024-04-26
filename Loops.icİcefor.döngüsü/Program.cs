using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.icİcefor.döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1
            12
            123
            1234
            12345
            123456
            1234567
            12345678
            123456789
            12345678910
             */
            /*for (int i = 1; i <= 10; i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write(j);
                  }
                  Console.WriteLine("");//içteki for komutu 2 olunca önceki for komutundaki i degeri olan 1'i geçemediği için alttaki boşluğu bırakıp en başa sarar.
              }
              Console.ReadLine();
            ______________________________________________________________
              */


            /*_________________________________________
             * 12345678910
             * 123456789
             * 12345678
             * 1234567
             * 123456
             * 12345
             * 1234
             * 123
             * 12
             * 1
             for(int a=10;a>=1; a--)
            {
                for(int b=1;b<=a;b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
            ____________________________________
            _____________________________________
            */


            /* 
            **********
            **********
            **********
            **********
            **********
            **********
            **********
            for (int a=1;a<=10;a++)
            {
                for (int b=1;b<=10;b++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            /*________________________________
             __________________________________
            * *
            *  *
            *   *
            *    *
            *     *
            *      *
            *       *
            *        *
            *         *
            *          *
            for(int a=1;a<=10;a++)
            {
                Console.Write("*");
                for(int b=1;b<=a;b++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.ReadLine();
            */
            /*___________________________________
             ____________________________________
             * 
             **
             ***
             ****
             *****
             ******
             *******
             ********
             *********
             **********
             
             */
            for(int a=1;a<=10;a++)
            {
                for(int b=1;b<=a;b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();

             
             










        }
    }
}
