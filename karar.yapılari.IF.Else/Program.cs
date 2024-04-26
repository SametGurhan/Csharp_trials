using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar.yapılari.IF.Else
{
    class Program
    {
        static void Main(string[] args)
        { 
            //2 alternatifin olduğu yerde : Ya if blokları çalışır, ya else blokları çalışır.
            //if (conditional-yerel kod) { } + else { }
            
            /*
                Console.WriteLine("Lütfen öğrencinin notunu giriniz");
            string not =Console.ReadLine();
            int notint = Convert.ToInt32(not);
            if(notint>=50)
            {
                Console.WriteLine("Öğrenci bu dersten başarılı bir şekilde gecmiştir.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dersten başarısız oldunuz.");
                Console.ReadLine();
            }
            */
            // __________________________________________________________________________________________________
            //SINGLE LINE IF-- if görevi gören tek satır bir koddur
            int sayi = 11;

            Console.WriteLine(sayi == 10 ? "sayı 10 " : "sayı 10 değil");
            Console.ReadLine();

        }
    }
}
