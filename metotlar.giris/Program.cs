using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar.giris
{
    class Program
    {
        static void Main(string[] args)//main den sonrası parametredir..
        {//parametresiz|geriye değer döndürmeyen metot tanımlama...

            Selamver();
            Selamver();//metotlar sayesinde uzun uzun kod yazmaya kopyla yapıştıra gerek yok.
            adiniyazdir();

        }
        static void Selamver()
        {
            Console.WriteLine("Selamlar:).Lütfen enter tuşu ile devam ediniz.");
            Console.ReadLine();
        }

        static void adiniyazdir()
        {
            Console.WriteLine("Lütfen adınızı yazınız:");
            string ad = Console.ReadLine();
            Console.WriteLine("Hoşgeldin "+ad+":)");
            Console.ReadLine();
        }

    }
}
