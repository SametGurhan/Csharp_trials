using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ör_Satırtoplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[20, 100];
            Random rnd = new Random();
            for(int i=0;i<20;i++)
            {
                int satirtoplami = 0;
                for(int j=1;j<100;j++)
                {
                    dizi[i, j] = rnd.Next(1, 100);
                    satirtoplami += dizi[i, j];
                }
                Console.WriteLine(satirtoplami);
                Console.ReadLine();
            }


        }
    }
}
