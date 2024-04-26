using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek.kareleri.seklinde.yazılır.mi
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
           
            while (true)
            {
                {
                    {
                        Console.WriteLine("a sayısı gir karşim.");

                        int a = Convert.ToInt32(Console.ReadLine());
                        for (int b = 1; b <= a; b++)
                        {
                            for (int c = 1; c <= a; c++)
                            {
                                if ((b * b + c * c) == a)
                                {
                                    Console.WriteLine(b +","+ c + "Girilen a sayısı b^2+c^2=a şartını sağlar.");
                                    flag += 1;
                                    break;
                                }
                                if(flag==1)
                                {
                                    break;
                                }
                            }
                        }

                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("Bulamadık...");
                    }
                    Console.WriteLine("1e bas");
                    Console.ReadLine();
                }
            }
        }
    }
}