using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedErisimBelirleyicisi
{
    class Program
    {
        static void Main(string[] args)
        {//Protected erişim belirleyicisi tekrar
         //Super class==base class==mirası veren class
         //sub class==alt class
            /*papatya sub class olacak, bitki superclass olacak*/
            Papatya p = new Papatya();
            p.papatyaBiilgileri();
            Console.ReadLine();

        }
    }
}
