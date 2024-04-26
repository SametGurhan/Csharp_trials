using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ve.operatörü
{
    class Program
    {
        static void Main(string[] args)
        {//(shift+6)*2= Ve operatörü= &&
            int a = 5;
            int b = 5;
            int c = 10;
            bool kontrol = a == b && b > c; // sartların ikisi de sağlaırsa true döner. 
            Console.WriteLine(kontrol);
            Console.ReadLine();




        }
    }
}
