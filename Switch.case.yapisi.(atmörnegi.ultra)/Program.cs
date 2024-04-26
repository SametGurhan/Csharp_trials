using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.@case.yapisi._atmörnegi.ultra_
{
    class Program
    {
        static void Main(string[] args)
        {//____________________________________
         //Switch(...){} case(..): / default: /break; işlemleri uygulanır. 
         //______________________________________
         //1-bakiye görüntüle
         //2-para çek
         //3-para yatır
         //4-Çıkıs yapmaya yarasın. aksi bir tuş ise hata versin.
            int bakiye = 2000;
            char devam;
            do
            {
                Console.WriteLine("Sambank atm'ye hoşgeldiniz...");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("1-bakiye görüntüleme");
                Console.WriteLine("2-para çekme");
                Console.WriteLine("3-para yatırma");
                Console.WriteLine("4-çıkış yapma için kullanılır.");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Bakiyeniz:" + bakiye);
                        Console.WriteLine("e tuşuna basarak menüye dönebilirsiniz.");
                        break;

                    case "2":
                        Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz.(bu tutar bakiyenizden büyük olmamalı...)");
                        int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                        if (cekilecek_tutar > bakiye)
                        {
                            Console.WriteLine("Lütfen bakiyenizden büyük bir değer tuşlamayın.");
                            Console.WriteLine("e tuşuna basarak menüye dönebilirsiniz.");
                        }
                        else
                        {
                            Console.WriteLine("İşlem tamamlandı.Mevcut bakiyeniz:" + (bakiye - cekilecek_tutar));
                            Console.WriteLine("e tuşuna basarak menüye dönebilirsiniz.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Lütfen yatırılacak tutarı giriniz.Yatırılabilecek maksimum tutar:" + (1000000000 - bakiye));//1milyar
                        int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                        if (yatırılacak_tutar > (1000000000 - bakiye))
                        {
                            Console.WriteLine("Lütfen uyarıyı dikkate alarak işlem yapınız.");
                            Console.WriteLine("e tuşuna basarak menüye dönebilirsiniz.");
                        }
                        else
                        {
                            Console.WriteLine("İşlem tamamlandı.Mevcut bakiyeniz:" + (bakiye + yatırılacak_tutar));
                            Console.WriteLine("e tuşuna basarak menüye dönebilirsiniz.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Hesabınızdan çıkış yapılıyor.İyi günler dileriz...");
                        break;

                    default:
                        Console.WriteLine("Lütfen e tuşuna basarak menüye dönüp geçerli bir komut giriniz.");
                        
                        break;
                }
                devam = Convert.ToChar(Console.ReadLine());
            }
            while (devam == 'e');
            Console.ReadLine();

        }
    }
}
