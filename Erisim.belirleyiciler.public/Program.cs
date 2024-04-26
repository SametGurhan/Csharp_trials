using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Erisim.belirleyiciler.@public
{
    class Program
    {
        static void Main(string[] args)
        {
            isci isci1 = new isci();
            isci i1 = new isci();
            i1.bilgilerigoster(); 
            Console.WriteLine(i1.id);
            Console.WriteLine(i1.isim);
            i1.soyisim = "Gürhan";
            Console.WriteLine(i1.soyisim);
            Console.ReadLine();
            
            

        }
    }
}
