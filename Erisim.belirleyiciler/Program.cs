using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim.belirleyiciler
{
    class Program
    {
        static void Main(string[] args)
        {//ERİSİM BELİRLEYİCİLER?? ACCES MODİFİERS
         //Private:Sadece bulunduğu class içinden erişilen ve sadece bulunduğu classa özgü olan erişim belşrleyicisidir
         //protected:Bulunduğu class içinden erişilen ve bulunduğu classı miras alan classlar içinden erişilir
         //ınternal:bulunduğu proje içerisinden her yerden erişilebilen bir erişim belirleyicidir
         //Public: hiç bir kısırlamas olmayan her yerden erişimimize olanak saplayan erişim belirleyicisi...

            Ögrenci o1 = new Ögrenci();

            Console.WriteLine("console ile yazdırılan kısımlarım:");
            Console.WriteLine(o1.okul);
           // o1.setisim("Samet");// x.setisim("atanacaksey"); ++ veritipi yeniadınismi=x.getisim();
           //string gelenisim = o1.getisim();
           //Console.WriteLine(gelenisim);
            Console.WriteLine(o1.soyisim);
            Console.Write("Metottan yazdırdığım okul:");

            o1.okulYazdır();

            Console.ReadLine();




        }
    }
}
