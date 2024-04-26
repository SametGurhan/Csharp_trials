using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @double
{
    class Program
    {
        static void Main(string[] args)
        {
            //double 8byte yer kaplar(float(f)<double)
            //15basamaklı ondalıklı sayılara kadar çıkar.
            double sayi = 350.17;
            double max = double.MaxValue;
            double sayi2=3.1;
            double min = double.MinValue;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
