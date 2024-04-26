using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ek.operatörler
{
    class Program
    {
        static void Main(string[] args)
        {/* +=
            -=
            *=
            /=
         */
            int a = 5;
            a += 4;//a = a + 4; (9 olarak yazdıracak.)
            int b = 6;
            b /= 2;//b=b/2; anlamına gelir.
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
