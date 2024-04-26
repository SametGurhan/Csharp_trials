using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimOrnek
{
   public class ucgen:sekil
    {
        public int tabanalanı { get; set; }
        public int yükseklik { get; set; }

        public ucgen(string isim, int tabanalanı,int yükseklik):base(isim)
        {
            this.tabanalanı = tabanalanı;
            this.yükseklik = yükseklik;
        }
        public override void sekilhesapla()
        {
            base.sekilhesapla();
           
            Console.WriteLine(getisim() + "'nin alanı:" + (tabanalanı * yükseklik)/2);
        }
        public override void sekilbilgilerigoster()
        {
            base.sekilbilgilerigoster();
            Console.WriteLine("seklin ismi:" + getisim());
            Console.WriteLine(getisim() + " in taban alanı:" + this.tabanalanı);
            Console.WriteLine(getisim() + "in yüksekliği:" + this.yükseklik);

        }



    }
}
