using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler.giriş
{
    class Program
    {
        static void Main(string[] args)
        {   //string""
            //double (boş)
            //char''
            //int""

            /*int[] sayilar = new int[4];
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
            */
            /*
             _____________________________________________
            string[] isimler = { "Samet", "Sefa", "Ercan", "Mehmet", "Eren" };
            for(int i=0;i<isimler.Length;i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();
            */
            /*________________________________________________
            double[] ondaliklilar = { 1.50, 1.90, 2.10, 2.80, 3.00 };
            for (int i = 0; i < ondaliklilar.Length; i++)
            {
                Console.WriteLine(ondaliklilar[i]);
            }
            Console.ReadLine();
            */
            //________________________________________________
            /*
             char[] karakter = { 'S', 'A', 'M', 'E', 'T' };
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);

            }
            */
            //________________________________________________
            /*
            string[] students = new string[3] {"Engin","Derin","Salih"}; // dizi olustururken kaclı olacagını belirtebilirsin.
            string[] students2 ={"Eren","Semih","Sarp"};
            students[2] ="Kübra"; //indeksi baz alırsan degisim yaparsın

            foreach (var student in students) { Console.WriteLine(student); }
            Console.WriteLine("Diğer Sınıf:");
            foreach (var student in students2) { Console.WriteLine(student); }
            */
            //___________________UZUN DIZI YAZIMI__________________

            string[,] regionstr = new string[5, 3] //5satır 3sutun
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }

            };

            for (int i = 0; i <= regionstr.GetUpperBound(0); i++) //satırlar 0.dimension sutunlar 1. dimensiondur.
            {
                for (int j = 0; j <= regionstr.GetUpperBound(1); j++)
                {
                    
                    Console.WriteLine(regionstr[i,j]);
                }
                Console.WriteLine("_________________");
            }
            Console.ReadLine();


        }
    }
}
