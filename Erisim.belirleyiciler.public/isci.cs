using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim.belirleyiciler.@public
{
    class isci
    {
        public int id = 1;
        public string isim = "Samet";
        public string soyisim { get; set; }
        public void bilgilerigoster()
        {
            Console.WriteLine("İşçi id:" + id);
            Console.WriteLine("İsim:" + isim);
            Console.WriteLine("Soyisim:" + soyisim);
        }
        private void deneme()//gizliii
        { Console.WriteLine("deneme"); }
    }
}
