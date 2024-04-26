using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimOrnek
{
    public class kare:sekil
    {
        public int kenar { get; set; }
        public kare(string isim, int kenar):base(isim)
        {
            this.kenar = kenar;
        }
        public override void sekilhesapla()
        {
            base.sekilhesapla();
            Console.WriteLine(getisim()+"nin alanı:"+kenar*kenar);
        }
        public override void sekilbilgilerigoster()
        {
            base.sekilbilgilerigoster();
            Console.WriteLine("seklin ismi:" + getisim());
            Console.WriteLine(getisim() + " in kenari:" + this.kenar);
    

        }


    }
}
