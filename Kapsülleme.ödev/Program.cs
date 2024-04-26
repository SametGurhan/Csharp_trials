using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme.ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            personel p1 = new personel();
            Console.WriteLine("Lütfen tc kimlik numaranızı doğrulamak için giriniz...");
            p1.TCKİMLİKNO = Console.ReadLine();
            Console.WriteLine("Tc kimlik numaranız:"+p1.TCKİMLİKNO);
            Console.ReadLine();
        }
    }
}
