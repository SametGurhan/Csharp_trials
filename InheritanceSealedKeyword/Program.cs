using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //sealed anahtar kelimesi nedir?_mühürleyiciydi bu.
         //  personel klasında başlığa işledim ve erişim kısıtadı
            musteri musteri = new musteri();
            musteri.personel_id = 1;
            musteri.personel_ismi ="Samet";
            musteri.personel_soyismi ="Gürhan";
            musteri.personel_maas =2500;

            musteri.PersonelBilgileri();
            Console.ReadLine();
        
        }
    }
}
