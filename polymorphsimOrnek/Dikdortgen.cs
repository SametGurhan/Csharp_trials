using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimOrnek
{
    public class Dikdortgen : sekil
    {
        public int kisakenar { get; set; }
        public int uzunkenar { get; set; }
        public Dikdortgen(string isim, int kisakenar,int uzunkenar) : base(isim)
        {
            this.kisakenar = kisakenar;
            this.uzunkenar = uzunkenar;
        }
        public override void sekilhesapla()
        {
            base.sekilhesapla();
            Console.WriteLine(getisim()+"'nin alanı:"+kisakenar*uzunkenar);
        }
        public override void sekilbilgilerigoster()
        {
            base.sekilbilgilerigoster();
            Console.WriteLine("seklin ismi:"+getisim());
            Console.WriteLine(getisim()+" in kısa kenari:"+this.kisakenar);
            Console.WriteLine(getisim()+"in uzun kenari:"+this.uzunkenar);
        }


    }
}
