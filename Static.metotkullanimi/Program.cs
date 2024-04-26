using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.metotkullanimi
{
    class Program
    {
        static void Main(string[] args)
        {//static komutu classlara direkt erişim sağlar.
         //yoksa personel.m1=new.personel();
         //p1.isimyazdir(); falan diye yazmak gerekirdi


             personel.isimsoyisimyazdir();
             Console.WriteLine("Lütfen art arda 2 sayı giriniz.Daha sonra otomatik toplanacaktır...");

             personel.sayilaritopla(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
            // Console.ReadLine();

            // __________________________________________________________________________________________________
            //SINGLE LINE IF-- if görevi gören tek satır bir koddur
            int sayi = 11;

            Console.WriteLine(sayi==10 ?"sayı 10 ":"sayı 10 değil");
            Console.ReadLine();
        }
    }
}
