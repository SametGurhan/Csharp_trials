using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancegiris
{
    public class hayvan
    {
        public string hayvan_isim;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        private int hayvan_yas;//gizli kalsın
        public void hayvanbilgisigoster()
        {
            Console.WriteLine("Hayvanın ismi:"+hayvan_isim);
            Console.WriteLine("Hayvanın cinsiyeti"+hayvan_cinsiyet);
            Console.WriteLine("Hayvanın rengi"+hayvan_rengi);

        }

    }
}
