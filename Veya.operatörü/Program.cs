using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veya.operatörü
{
    class Program
    {
        static void Main(string[] args)
        { //veya operatörü= || ;yalnızca bir koşulsaglansa bile true döner.
            int a = 5;
            int b = 5;
            int c = 10;
            bool kontrol = a == b || b == c;
            Console.WriteLine(kontrol);
            Console.ReadLine();


        }
    }
}
