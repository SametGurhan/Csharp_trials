using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ör_dikdörtgen_alancevre
{
    class Program
    {
        static void Main(string[] args)
        {
            double kısa, uzun, cevre, alan ;
            Console.WriteLine("Kısa kenar:");
            kısa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Uzun kenar:");
            uzun = Convert.ToDouble(Console.ReadLine());
            alan = uzun * kısa;
            cevre = 2 * (uzun + kısa);
            Console.WriteLine("Çevre:"+cevre);
            Console.WriteLine("Alan:" + alan);
            Console.ReadLine();

        }
    }
}
