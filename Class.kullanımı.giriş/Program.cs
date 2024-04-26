using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.kullanımı.giriş
{
    class Program
    {
        static void Main(string[] args)
        {//yapıcı metot=classlardan obje oluşturduğum sırada oluşan, geriye dönüş tipi olmayan metottur.

            /*
            araba araba1=new araba();

            araba1.kapisayisi = 4;
            araba1.arabarengi = "kırmızı";
            araba1.arabamodeli = "Renault";
            araba1.kapilarikilitle();
            araba1.motorcalistir();

            Console.WriteLine("Arabanın kapı sayısı:"+araba1.kapisayisi);
            Console.WriteLine("Araba rengi :"+araba1.arabarengi);
            Console.WriteLine("Arabanın modeli:"+araba1.arabamodel);
            Console.ReadLine();



            */


            araba araba1 = new araba(4, "Renault", "Kırmızı") ;

            

            Console.WriteLine("Arabanın kapı sayısı:"+araba1.kapisayisi);
            Console.WriteLine("Araba rengi :"+araba1.arabarengi);
            Console.WriteLine("Arabanın modeli:"+araba1.arabamodel);
            Console.ReadLine();
            
 

        }
    }
}
