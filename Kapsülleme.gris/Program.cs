using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme.gris
{
    class Program
    {
        static void Main(string[] args)
        {//geter seter metotlar
            //property ile
            öğrenci öğrenci1 = new öğrenci();

            öğrenci1.setisim("Samet");
            string gelenisim= öğrenci1.getisim();

            if(gelenisim=="Samet")
            {
                Console.WriteLine("Başarılı");
            }
            else
            { 
                Console.WriteLine("Başarısız.."); 
            }
            Console.ReadLine();

        }
    }
}
