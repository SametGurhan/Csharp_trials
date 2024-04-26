using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @float
{
    class Program
    {
        static void Main(string[] args)
        {//float(4byte),f kullanılarak yazılmalıdır.Yoksa doubledan kaynaklanan hata oluşur.
            float a = 35.56f;
            float b = 12.5f;
            float max = float.MaxValue;
            float min = float.MinValue;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine();

        }
        
    }
}
