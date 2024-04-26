using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Toplama_islem_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Toplama işlemini öğretmeye çalışan bir oyun programı yazılacaktır.
             * Oyun başladığı zaman rastgele 2 tane 1-100 arasında sayı tutulacak,
             * tutulan sayılar ekrana gösterilecek ve kullanıcıya bu sayıların toplamı nedir diye sorulacaktır.
             * Eğer kullanıcı doğru cevap verirse “Tebrikler Bildiniz” değil ise “Üzgünüm Bilemediniz” diye mesaj verecektir. 
             * Her cevaptan sonra “Tekrar Oynamak istiyormusunuz(e/E)?” şeklinde bir soru sorulacak ve eğer kullanıcı “e” veya “E” ile karşılık verirse oyun tekrar başlayacaktır.
             * Kullanıcının puanı her doğru cevap için 5 puan artacak, her yanlış cevap için ise 2 puan azalacaktır. 
             * Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı, yanlış cevap sayısı ve puanı ekranda listelenmelidir.
             * Bu işlemleri yapan programın kodlarını yazınız.
             */
            Random rnd = new Random();
            int ilkSayi = 0, ikinciSayi = 0, toplampuan = 0, sayilarintoplami=0,girilencevap = 0, dogrucevapsayisi = 0, yanliscevapsayisi = 0;
            char devam;
            do
            {
                ilkSayi = rnd.Next(1, 100);
                ikinciSayi = rnd.Next(1, 100);
                Console.WriteLine("ilk sayı:"+ilkSayi+" ikinci sayı:"+ikinciSayi);

                sayilarintoplami = ilkSayi + ikinciSayi;
                Console.WriteLine("ilk ve ikinci sayının toplamı nedir?");
                Console.Write("Cevabınız:");
                girilencevap = Convert.ToInt32(Console.ReadLine());

                if (girilencevap == sayilarintoplami)
                {
                    Console.WriteLine("Tebrikler, doğru cevap verdiniz.");
                    dogrucevapsayisi += 1;
                    toplampuan += 5;
                    Console.WriteLine("Doğru cevap sayınız:"+dogrucevapsayisi);
                    Console.WriteLine("Toplam  puanınız:"+toplampuan);
                }

                else
                {
                    Console.WriteLine("Cevabınız hatalı.");
                    yanliscevapsayisi += 1;
                    toplampuan -= 2;
                    Console.WriteLine("Yanlış cevap sayınız:"+yanliscevapsayisi);
                    Console.WriteLine("Toplam  puanınız:" + toplampuan);
                }
                Console.WriteLine("Tekrar oynamak istiyorsanız e veya E tuşlayınız. ");
                devam = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("____________________________________________________________");
            }
            while (devam == 'e'|| devam == 'E');

            Console.ReadLine();


        }
    }
}
