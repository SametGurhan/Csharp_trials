using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancegiris
{
    class Program
    {
        static void Main(string[] args)
        {
            kedi kedi = new kedi();
            kedi.hayvan_isim = "Boncuk";
            kedi.hayvan_cinsiyet = "disi";
            kedi.hayvan_rengi = "Beyaz";
            kedi.kedinin_goz_rengi = "mavi";
            kedi.hayvanbilgisigoster();

            Console.ReadLine();
        }
    }
}
