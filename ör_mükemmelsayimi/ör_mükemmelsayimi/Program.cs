using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ör_mükemmelsayimi
{
    class Program
    {
        static void Main(string[] args)
        {/*Kendisi hariç bütün pozitif çarpanları (tam bölenleri) toplamı,
          * yine kendisine eşit olan sayılara “mükemmel sayı” denir. Örneğin
          * 6=1+2+3 ve 28=1+2+4+7+14 gibi. Buna göre klavyeden girilen bir 
          * tamsayının “mükemmel sayı” olup olmadığını kontrol eden MukemmelSayi
          * adında bir metot tanımlayınız. Metot eğer sayı mükemmel sayı ise ekrana “Mükemmel Sayıdır” değilse
          * “Mükemmel Sayı DEĞĠLDĠR” yazan programın kodlarını yazınız. 
          */
            
            
                
            char devam;
            do
            {
                Console.WriteLine("Mükemmel sayı oyununa hoşgeldiniz.Lütfen bir sayı tuşlayınız.");
                int bölentoplami = 0;
                int sayi = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        bölentoplami += i;
                    }
                }
                if (sayi == bölentoplami) { Console.WriteLine("Girdiğiniz sayı mükemmel bir sayıdır."); }
                else { Console.WriteLine("Girdiğiniz sayı mükemmel sayı değildir"); }
                Console.WriteLine("Devam için e bas.");
                devam = Convert.ToChar(Console.ReadLine());
                
            }
            while (devam == 'e');
            Console.ReadLine();
                
            
            
            

        }
    }
}
