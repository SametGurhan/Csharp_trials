using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte ile işlem yapıp max min deger buldum.
            /*   byte sayi = 31;
               Console.WriteLine(sayi);
            */
            byte maxdeger = byte.MaxValue;
            byte mindeger = byte.MinValue;
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();

        }
    }
}
