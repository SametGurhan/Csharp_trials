using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @long
{
    class Program
    {
        static void Main(string[] args)
        {//byte<short<int<long
            //long bayağı uzun karakterler(tc için falan) için kullanılıyor
            //8bit=1byte,short=2byte,int=4byte,long=8byte,float=4byte,double=8byte,boolean=1bit(1/8byte)
            long sayi = 123;
            long max = long.MaxValue;
            long min = long.MinValue;
            Console.WriteLine(sayi);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine();

        }
    }
}
