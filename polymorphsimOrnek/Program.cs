using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine("Şekil uygulamasına hoşgeldiniz...");
                Console.WriteLine("1-Dikdörtgen işlemleri");
                Console.WriteLine("2-Üçgen işlemleri");
                Console.WriteLine("3-Kare işlemleri");
                Console.WriteLine("Q ile çıkış yapabilirsiniz.");

                string secim = Console.ReadLine();

                if (secim == "q")
                {
                    break;

                }

                else if (secim == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Dikdörgen alanı hesapla");
                      
                        Console.WriteLine("2-Dikdörtgen bilgileri göster");
                        
                        Console.WriteLine("3-Dikdörtgen uygulamasından çıkış yap");
                       
                        string secimdikdorten = Console.ReadLine();
                        if (secimdikdorten == "1")
                        {
                            Console.WriteLine("Kısa kenarı giriniz.");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun kenarı giriniz.");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdortgen", kisakenar, uzunkenar);
                            dikdortgen.sekilhesapla();
                        }
                        else if (secimdikdorten == "2")
                        {
                            Console.WriteLine("Kısa kenarı giriniz.");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun kenarı giriniz.");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdortgen", kisakenar, uzunkenar);
                            dikdortgen.sekilbilgilerigoster();
                        }
                        else if (secimdikdorten == "3")
                        {
                            Console.WriteLine("Dikdörtgen uygulamasından çıkılıyor...");
                            break;
                        }

                    }
                }
                else if (secim == "2")
                {
                    
                   
                    while (true)
                    {
                        Console.WriteLine("1-Üçgenin alanı hesapla");
                  
                        Console.WriteLine("2-Üçgen bilgileri göster");
                    
                        Console.WriteLine("3-Üçgen uygulamasından çıkış yap");
                        string secimucgen = Console.ReadLine();

                        if (secimucgen == "1")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz:");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Üçgenin yüksekliğini giriniz:");
                            int yükseklik = Convert.ToInt32(Console.ReadLine());

                            ucgen ucgen = new ucgen("Üçgen", tabanalani, yükseklik);
                            ucgen.sekilhesapla();

                        }

                        else if (secimucgen == "2")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz:");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Üçgenin yüksekliğini giriniz:");
                            int yükseklik = Convert.ToInt32(Console.ReadLine());
                            ucgen ucgen = new ucgen("Üçgen", tabanalani, yükseklik);
                            ucgen.sekilbilgilerigoster();
                        }
                        else if (secimucgen == "3")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor..");
                            break;
                        }
                    }






                }
                else if (secim == "3")
                {
                   
                    while (true)
                    {
                        Console.WriteLine("1-Karenin alanı hesapla");
                   
                        Console.WriteLine("2-Kare bilgileri göster");
                   
                        Console.WriteLine("3-Kare uygulamasından çıkış yap");

                        string secimkare = Console.ReadLine();
                        if (secimkare == "1")
                        {
                            Console.WriteLine("Karenin kenarını giriniz:");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            kare kare = new kare("Kare", kenar);
                            kare.sekilhesapla();

                        }
                        else if (secimkare == "2")
                        {
                            Console.WriteLine("Karenin kenarını giriniz:");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            kare kare = new kare("Kare", kenar);
                            Console.WriteLine();
                            kare.sekilbilgilerigoster();

                        }
                        else if(secimkare=="3")
                        { 
                            Console.WriteLine("Kare işlemlerinden çıkış yapılıyor..");
                            break;
                        }
                    }
                }
                else
                { Console.WriteLine("Geçersiz bir değer girdiniz."); }






            }
        }

    }
}