using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpim.tablosu.örnek.for_döngü_
{
    class Program
    {
        static void Main(string[] args)
        {//Bu projede for döngüsü ile çarpım tablosu yapıyorum.
            for(int a=1;a<=10;a++)
            {
                for(int b=1;b<=10;b++)
                {
                    Console.WriteLine(a+"*"+b+"="+(a*b));

                }
            }
            Console.ReadLine();

        }
    }
}
