using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çoklu.kararyapilari.@if.elseif.@else
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcıdan 3tane değer alan ve bu notların ortalamısnı bulup eğer bu ortlama :
            //80-100 arasındaysa A+ 
            //60-80 arasındaysa A
            //40-60 arasındaysa B+
            //40tan küçükse F yazdıran kodu yazınız.

            Console.WriteLine("Lütfen birinci notu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci notu giriniz");
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü notu giriniz");
            int ücüncü_not = Convert.ToInt32(Console.ReadLine());
            int ort = (birinci_not + ikinci_not + ücüncü_not) / 3;
            if (ort >= 80 && ort <= 100)
            {
                Console.WriteLine("Not degeriniz:A+");
            }
            else if (ort >= 60 && ort < 80)
            {
                Console.WriteLine("Not degeriniz:A");
            }
            else if (ort >= 40 && ort < 60)
            {
                Console.WriteLine("Not degeriniz:B+");
            }
            else
            {
                Console.WriteLine("Not değeriniz:F(Dostum çalışmanı öneririm)");
            }
            Console.ReadLine();








        }
    }
}
