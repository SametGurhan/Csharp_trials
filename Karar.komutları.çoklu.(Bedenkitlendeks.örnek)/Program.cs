using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar.komutları.çoklu._Bedenkitlendeks.örnek_
{
    class Program
    {
        static void Main(string[] args)
        {// Beden kitle indeksi=Kilo/boy*boy
            //Beden kitle indeksi 18'e eşit veya düşükse NORMALİN ALTINDA BİR KİLODASINIZ
            //18ile 25 arası ise NORMAL KİLODA
            //25'e eşit veya büyükse NORMALDEN FAZLA BİR KİLODASINIZ yazdıracak kodlama:
            Console.WriteLine("Kilonuzu kg cinsinden giriniz:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuzu metre cinsinden giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bke = kilo / (boy * boy);
            Console.WriteLine(bke);
            if (bke <= 18)
            {
                Console.WriteLine("Normal kilonuzun altındasınız...");
            }
            else if (bke > 18 && bke <= 25)
            {
                Console.WriteLine("Normal bir kilonuzdasınız...");
            }
            else
            {
                Console.WriteLine("Normal kilonuzun üstündesiniz...");
            }
            Console.ReadLine();


        }
    }
}
