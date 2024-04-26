using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullaniciden.deger.alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soy adınızı da giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("kullanıcı ismi="+ ad);
            Console.WriteLine("kullanıcı soyismi="+soyad);
            Console.ReadLine();



        }
    }
}
