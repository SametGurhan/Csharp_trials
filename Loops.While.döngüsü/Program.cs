using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.While.döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {//while(şart)
         //{
         //kodlar
         //}
         //1den 10a kadar olan sayıları ekrana yazdır.
            /*
               int a = 1;
               while(a<=10)
               {
                   Console.WriteLine(a);
                   a++;
               }
               Console.ReadLine();
            */
            //100den 0a kadar olan sayıların çift olanlarını büyükten küçüğe yazdır.
            int a = 100;
            while(a>=0)
            {
                Console.Write(a+" ");
                a -= 2;
            }
            Console.ReadLine();


        }
    }
}
