using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen.sayi.tekmi.çiftmi
{
    class Program
    {
        static void Main(string[] args)
        {//kullanıcıdan 10 int deger alıcaz
            //kaç adet tek kaç adet çift olduğunu 
            //çift degerlerin toplamını ve tek degerlerin toplamını
            //eğer teklerin top buyukse tektop>çifttop fln yazıcaz
            int[] sayilar = new int[10];
            int tekadettop = 0;
            int ciftadettop = 0;
            int teksayilartop = 0;
            int ciftsayilartop = 0;
            int kullanicideger;
            for (int i = 0; i <sayilar.Length; i++)
            {
                Console.Write((i + 1) + ".index değerini giriniz::");
                
                    
                    kullanicideger = Convert.ToInt32(Console.ReadLine());//girileni(string)integera çevirdim.
                
                sayilar[i]=kullanicideger; //diziyi kulanıcının girdikleriyle doldurdum
            }
            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftadettop++;
                    ciftsayilartop += sayilar[j];
                }
                else
                {
                    tekadettop++;
                    teksayilartop += sayilar[j];

                }
            }

            if (ciftsayilartop > teksayilartop)
            {
                Console.WriteLine("Çift sayıların toplamı ,tek sayıların toplamından büyüktür.");
            }
            else
            {
                Console.WriteLine("tek sayıların toplamı ,çift sayıların toplamından büyüktür.");
            }




            Console.WriteLine("***********************************");
            Console.WriteLine("Çift sayiların toplamı:" + ciftsayilartop);
            Console.WriteLine("Çift sayiların adet toplamı: " + ciftadettop);
            Console.WriteLine("************************************");
            Console.WriteLine("Tek sayilar toplamı:" + teksayilartop);
            Console.WriteLine("Tek sayiların adet toplamı:"+tekadettop);
            Console.ReadLine();
        }
    }
}
