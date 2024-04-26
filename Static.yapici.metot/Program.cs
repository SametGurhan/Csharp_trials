using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.yapici.metot
{
    class Program
    {
        //static metot parametresiz olmak zorundadır.erişim belirleyicii olmaz bu metotun.
        //kaç nesne oluşursa oluşsun 1 kere çalısır.



        static void Main(string[] args)
        {
            kullanici k1 = new kullanici(1, "Samet", "Gürhan");

            k1.bilgileriGoster();
            k1.zamyap(700);

            Console.ReadLine();
        }
    }
}
