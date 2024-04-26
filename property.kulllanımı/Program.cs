using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property.kulllanımı
{
    class Program
    {
        static void Main(string[] args)
        {//PROPERTY NEDİR=ingiliz anahtarı=prop+tab+tab
            /* 
             Musteri musteri1 = new Musteri();
              musteri1.KİLO = 85;   //değer atama yaptım(set blokları çalıştı)
                                     //eğer değer ataması yapmasaydım o zaman get ler çalışırdı

               Console.WriteLine(musteri1.KİLO);
            */
            Musteri m1 = new Musteri();
            //m1.kilo1 = 85;
            //   m1.kilo2 = 85;

            // Console.WriteLine("Property olan kilo:"+m1.kilo1);
            // Console.WriteLine("Değişken olan kilo:"+m1.kilo2);
            //________________________________________________

            Musteri customer = new Musteri();
            //set işlemleri
            customer.city = "Kocaeli";
            customer.Id = 1;
            customer.name = "Aylin";
            customer.lastName = "Sarp";

            Musteri customer2 = new Musteri
            {
                //set işlemleri ama kısa
                Id = 2, city = "İstanbul", name = "Serhat", lastName = "Bedir"
            };

            Console.WriteLine(customer.name);//get işlemi
            Console.WriteLine(customer2.name);
            Console.ReadLine();

            

        }    
    }
    
}
