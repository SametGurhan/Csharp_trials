using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73._1_kapsulleme.ornek._ulke_
{
    class Program
    {
        static void Main(string[] args)
        {
            ulke ulke1 = new ulke();
            ulke1.Ad = "Türkiye";
            ulke1.Baskent = "Ankara";
            ulke1.Nufus = 85279553;
            ulke1.ParaBirimi = "TL";
            ulke1.yazdir();

            ulke devlet2 = new ulke();
            devlet2.Ad = "Almanya";
            devlet2.Baskent = "Berlin";
            devlet2.Nufus = 84400000;
            devlet2.ParaBirimi = "Euro";
            devlet2.yazdir();

            Console.ReadLine();


        }
    }
}
