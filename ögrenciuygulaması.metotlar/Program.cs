using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(210401030, "Samet", "Gürhan", 64, 92, 86, "Çomü");

            Console.WriteLine("Uygulamamıza hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz");
           


            while(kontrol)
            {
                islemleriGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        ogrenci1.ogrenciBilgileriGoster();
                        break;

                    case "2":

                     double ogrenciOrtalama=  ogrenci1.ogrenciNotuBul();
                        Console.WriteLine("Öğrencinin Ortalaması :"+ ogrenciOrtalama);
                        break;
                    case "3":

                        ogrenci1.okulGetir();

                        break;

                    case "4":
                        kontrol = false;
                        break;
                        

                }


            }




        }


        static void islemleriGoster()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("1- Öğrenci Bilgileri Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrenci Okulunu Göster");
            Console.WriteLine("4- Çıkış yap");
        }
    }
}
