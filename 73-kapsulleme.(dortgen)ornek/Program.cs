using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_kapsulleme._dortgen_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            dortgen d = new dortgen();
            Console.WriteLine("Boy gir:");
            d.Boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("En gir:");
            d.En = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Boy:" + d.Boy + " En:" + d.En);
            Console.Write("Alan: ");
            Console.Write(d.alan());
            Console.ReadKey();
        }
    }
}
