using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek.ebob
{
    class Program
    {
        static void Main(string[] args)
        {
        a2:
            int a, b;
            
            Console.WriteLine("ebobu alınacak sayıları gir");

           
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        a1:
            
            if (a > b)
            {
                a = a - b;
                goto a1;
            }
            else if (b > a)
            { b = b - a; goto a1; }

            Console.WriteLine("Ebob:" + a);

            goto a2;

            Console.ReadLine();
        }
    }
}
