using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erisim.belirleyicinternal.test;

namespace Erisim.belirleyiciler.ınternal
{
    class Program
    {
        static void Main(string[] args)
        {
            //ınternal:bulunduğu proje içerisinden her yerden erişilebilen bir erişim belirleyicidir
            musteri m1 = new musteri();
            m1.publicmetot();//internal için aynısı olamaz . o sadece kendi projesinde çalısır
            Console.ReadLine();

        }
    }
}
