using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.@foreach.döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {//for eachdöngüsü..
            string[] isimler = { "Samet", "Enes", "Ayşe", "Betül", "Su" };
           /* for(int i=0;i<isimler.Length ;i++)
            {
                Console.WriteLine(isimler[i]);
            }
           */
           foreach(string a in isimler)//foreach tab tab
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
