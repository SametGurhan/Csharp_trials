using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar.komutları.çoklu.Miniatm.örnek
{
    class Program
    {
        static void Main(string[] args)
        {//kullanıcıya nasıl bir işlem yapacağını soracağız.
            //1-bakiye görüntüleme
            //2-para çekme
            //3-para yatırma
            //q- çıkış yapma olacak.
            Console.WriteLine("Sambank atm'ye hoşgeldiniz");
            Console.WriteLine("1-Bakiye görüntüleme");
            Console.WriteLine("2-Para Çekme");
            Console.WriteLine("3-Para yatırma");
            Console.WriteLine("q-Çıkış yapma işlemleri için kullanılır.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            int bakiye = 2000;
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz:" + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Lütfen çekilecek tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar <=bakiye)
                {
                 Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz dostum...");
                }
                
                
            }
            else if (secim == "3")
            {
                Console.WriteLine("Lütfen yatırılacak tutarı giriniz");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mevcut bakiyeniz:" + (bakiye + yatırılacak_tutar));
            }
            else if (secim == "q")
            {
                Console.WriteLine("Başarıyla çıkış yapılmıştır, iyi günler dileriz...");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer tanımlayınız.");
            }
            Console.ReadLine();




        }
    }
}
