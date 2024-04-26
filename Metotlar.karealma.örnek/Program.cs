using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar.karealma.örnek
{
    class Program
    {
        static void Main(string[] args)
        {//kullanıcıdan alınan değerin karesinin 25'e göre durumunu belirtsin
            Console.WriteLine("bir rakam gir la:");
            int sayi = int.Parse(Console.ReadLine());
            int karedeger=kareal(sayi);
            if(karedeger>25)
            {
                Console.WriteLine("Sayının karesi 25'ten büyüktür.");
            }    
            else if(karedeger==25)
            {
                Console.WriteLine("sayının karesi 25'e eşittir.");
            }
            else
            { Console.WriteLine("Sayının karesi 25'ten küçüktür."); }
            Console.ReadLine();


        }
        static int kareal(int a)
        {
            return a * a;
        }




    }
}
