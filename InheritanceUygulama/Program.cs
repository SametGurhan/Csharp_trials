using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    class Program
    {
        static void Main(string[] args)
        {//Çalışan,Yazılımcı, Yönetici
            Console.WriteLine("Çalışan uygulamasına hoş geldiniz...");
            Console.WriteLine("___________________________________________________");

          

            while (true)
            {
                Console.WriteLine("1-Yazılımcı işlemleri:");
                Console.WriteLine("2-Yönetici işlemleri:");
                Console.WriteLine("3-Çıkış işlemi"); 
                string secilenislem = Console.ReadLine();
                if (secilenislem == "3")
                {

                    Console.WriteLine("Programndan çıkılıyor...");
                    break;
                }

                else if (secilenislem == "1")
                {
                    yazilimci yazilimci = new yazilimci(1, "Samet", "Gürhan", "C+,Java,C++");


                    while (true)
                    {
                        Console.WriteLine("___________________________________________________");

                        Console.WriteLine("Yazılımcı işlemi seçiniz.");
                        Console.WriteLine("1-format at");
                        Console.WriteLine("2-yazılımcı bilgilerini göster");
                        Console.WriteLine("3-3 ile çıkış yap");
                        string yazılımcıislem = Console.ReadLine();
                        if (yazılımcıislem == "3")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if (yazılımcıislem == "1")
                        {
                            Console.WriteLine("İşletim sistemini giriniz:");
                            string isletimsistemi = Console.ReadLine();
                            yazilimci.formatat(isletimsistemi);

                        }
                        else if (yazılımcıislem == "2")
                        { yazilimci.bilgilerigöster(); }

                        else { Console.WriteLine("Lütfen geçerli bir işlem giriniz..."); }


                    }
                }

                else if (secilenislem == "2")

                {
                    Yonetici yonetici = new Yonetici(2, "Sefa", "Ceylan", 12);


                    while (true)
                    {
                        Console.WriteLine("___________________________________________________");

                        Console.WriteLine("Yönetici işlemi seçiniz:");
                        Console.WriteLine("1-zam yap");
                        Console.WriteLine("2-yöneticinin bilgilerini göster");
                        Console.WriteLine("3-Çıkış için 3'e basın");
                        string yoneticiislemleri = Console.ReadLine();
                        if (yoneticiislemleri == "3")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if (yoneticiislemleri == "1")
                        {
                            Console.WriteLine("Zam miktarı giriniz:");
                            int zammiktari = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamyap(zammiktari);
                        }
                        else if (yoneticiislemleri == "2")
                        {
                            yonetici.bilgilerigöster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                    }
                }
                else
                { Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem giriniz"); }

            }





        }
    }
}
