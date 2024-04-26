using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_arrays_.var_mı_yok_mu
{
    class Program
    {
        static void Main(string[] args)
        {//kullanıcının girdiği sayı dizisinin içinde var mı? kontrol edip varsa kaç tane olduğunu yazdıran programı kodlayınız
            int[] sayilar = { 1, 1, 1, 1, 2, 3, 3, 5, 9, 3, 5, 10, 15, 20, 12, 14, 17, 18, 20 };
            int adet=0                                                                      ;
            int sayi;

            Console.Write("Lütfen 20'ye kadar bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            
            for (int i =0; i < sayilar. Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet!=0)
            {  Console.WriteLine("Girdiğiniz sayi dizide bulundu...;)");
               Console.WriteLine("Adet:" + adet);
                
            }
            else
            {
              Console.WriteLine("Girdiğiniz değer dizide bulunamadı.");


            }
                Console.ReadLine();
        }
    }
}
