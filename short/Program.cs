using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @short
{
    class Program
    {
        static void Main(string[] args)
        {//short da sayi tanimlar byte<short<int
            short sayi = 123;
            short sayi2 = 321;
            short maxsayi = short.MaxValue;
            short minsayi = short.MinValue;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);
            Console.WriteLine(maxsayi);
            Console.WriteLine(minsayi);
            Console.ReadLine();

        }
    }
}
