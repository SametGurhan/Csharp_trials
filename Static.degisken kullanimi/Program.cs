using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.degisken_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //static metto kullanımı (geçen ders)
            //static degisken kulllanımı<<
            //static yapıcı metot kullanımı
            //static class kullanimi

            Calisan c1 = new Calisan();
            c1.calisanID = 1;
            c1.isim = "Samet";
            c1.soyisim ="Gürhan";
            Calisan.maas = 1500;

            Console.WriteLine("çalışan id:"+c1.calisanID);
            Console.WriteLine("çalışan ismi:"+c1.isim);
            Console.WriteLine("çalışan soyismi:"+c1.soyisim);
            Console.WriteLine("çalışan maaşı:"+Calisan.maas);

            Console.ReadLine();


        }
    }
}
