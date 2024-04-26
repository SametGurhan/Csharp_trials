using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_kombinasyon.asal_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            char devam;
            do
            {
            long fn = 1;
            long fr = 1;
            long ff = 1;
            int flag = 0;
                Console.WriteLine("________________________________________________________");
            Console.WriteLine("n>r olacak şekilde sırayla n ve r değerini giriniz:");
            
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r=");
            int r = Convert.ToInt32(Console.ReadLine());
            int f = n-r;
            for(int i = 1; i <= n; i++) 
            {
                fn = fn * i;
            }

            for (int i = 1; i <= r; i++)
            {
                fr = fr * i;
            }

            for (int i = 1; i <= f; i++)
            {
                ff = ff * i;
            }
            long c = (fn) / (ff * fr);
            Console.WriteLine("Kombinasyon değeri:"+fn+"/"+fr+"*"+ff+"="+c);

            if(c==2)
            {
               flag = 1;
               Console.WriteLine("KOMBİNASYON ASAL ULAN");
               
            }
            
            for(int i=2;i<=c-1 ;i++)
            {
                if (c % i != 0) //1 dışındaki sayılara tam bölünmüyosa: asal
                {
                        flag = 1;
                
                        break;
                }
                else if(c % i== 0) //1 den başka bi sayıya bölünüyosa:asal deil
                {
                        break;
                 }
            }
            if (flag == 0)
            { Console.WriteLine("KOMBİNASYON ASAL DEĞİL :(("); }
            else
            { Console.WriteLine("KOMBİNASYON ASAL ULAN"); }

            Console.WriteLine("Devam için d bas");

            devam = Convert.ToChar(Console.ReadLine());


            }
            while (devam == 'd' || devam == 'D'); 
            Console.ReadLine();
           
        }
    }
}
