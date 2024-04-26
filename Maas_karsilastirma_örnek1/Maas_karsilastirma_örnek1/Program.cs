using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maas_karsilastirma_örnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ahmetMaas = 0, hasanMaas = 0, ekUcret = 0;
            int kacAy = 0;
            Console.Write("Ahmet'in Başlangıç Maaşı :" );
            ahmetMaas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hasan'ın Başlangıç Maaşı :" );
            hasanMaas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kaç Ay Sürecek:" );
            kacAy = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= kacAy; i++)
            {

                if (i % 2 == 0)
                {
                    //ahmetin para artacak
                    ekUcret = ahmetMaas * 0.5;
                    ahmetMaas += ekUcret;

                }
                else
                {
                    //ahmetin para azalacak
                    ekUcret = ahmetMaas * 0.25;
                    ahmetMaas -= ekUcret;

                }

                //hasanınki her türlü artacak

                ekUcret = hasanMaas * 0.25;
                hasanMaas += ekUcret;

                Console.WriteLine(+(i+1)+". Ayın Sonunda Ahmetin Maaşı :" +ahmetMaas +" Hasanın Maaşı:"+hasanMaas);
             }

            if (ahmetMaas > hasanMaas)
            {
                Console.WriteLine("Sonuç Olarak" + kacAy + "Ay Sonunda Ahmet, Hasandan Daha Fazla Maaş Almaktadır.");
            }
            else if (ahmetMaas == hasanMaas)
            {
                Console.WriteLine("Sonuç Olarak" + kacAy + "Ay Sonunda Ahmet ve Hasandan Eşit Fazla Maaş Almaktadır.");
            }
            else
            {
                Console.WriteLine("Sonuç Olarak" +kacAy+" Ay Sonunda Hasan, Ahmetten Daha Fazla Maaş Almaktadır." );
            }

            Console.ReadLine();

        }
    }
}
