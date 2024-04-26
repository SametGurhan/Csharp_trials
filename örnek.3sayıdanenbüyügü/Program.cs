using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek._3sayıdanenbüyügü
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            int eb;
            char devam;
            do
            {


                Console.WriteLine("Lütfen 3 tane sayı giriniz");



                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                eb = a;
                if (b > eb)
                {
                    eb = b;
                    if (c > eb)
                    {
                        eb = c;

                    }
                }


                Console.WriteLine("En büyük sayı:" + eb);
                Console.WriteLine("devam etmek için e basınız");
                Console.WriteLine("__________________________________________");
                devam = Convert.ToChar(Console.ReadLine());
            }
            while (devam == 'e' || devam == 'E');
            Console.ReadLine();



        }
    }
}
