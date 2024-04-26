using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanici.giris.sayfasi.örnek_döngü_
{
    class Program
    {
        static void Main(string[] args)
        {//kullanıcı giris sayfası yapacağım.
            //kullanıcı adı veya şifresini doğru girerse tebrikler fln yazacak.
            //yanlış girerse 3 hakkı olacak ve uyarı alacak.
            while(true)
            {
                int hak_sayisi = 3;

                Console.WriteLine("Kullanıcı adınızı giriniz.");
                string kullanici_ad = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz.");
                string sifre = Console.ReadLine();
                if(kullanici_ad=="samet"&&sifre=="123")
                {
                    Console.WriteLine("Tebrikler başarı ile giriş yaptınız.");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifreniz hatalı !");
                    if(hak_sayisi>0)
                    {
                        hak_sayisi -= 1;
                    }
                    if(hak_sayisi==0)
                    {
                        Console.WriteLine("Deneme hakkınız dolmuştur, daha giriş yapamazsınız!");
                        break;
                    }
                }

            }
            Console.ReadLine();








        }
    }
}
