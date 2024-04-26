using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar.ama.geriyedönüşlüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametre alan geriye dönüşlü metot tanımlama
            //return anahtar kelimesi
            //metot sonu
            Console.WriteLine("Lütfen 2 sayı tuşlayip enter'a basınız.");
            int dönendeger = toplamayap(Convert.ToInt32(Console.ReadLine()) ,Convert.ToInt32(Console.ReadLine()));
            
            
            if(dönendeger>10)
            {
                Console.WriteLine("Dönen değer 10'dan büyüktür.");
            }
            else
            {
                Console.WriteLine("Dönen değer 10'dan küçüktür.");
            }

            Console.WriteLine("İsim soyisim gir ulan kahpe:");
            string Gelenisimsoyisimdegeri = isimsoyisimdöndür(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("Girilen isim soyisim:");
            Console.Write(Gelenisimsoyisimdegeri);
            Console.ReadLine();

        }
        static int toplamayap(int sayi1,int sayi2)
        {
          
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        static string isimsoyisimdöndür(string isim,string soyisim)
        {
            return isim + " " + soyisim;

        }
    }
}
