using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
   public class Yonetici:Calisan
    {
        private int sorumlukisisayisi;
        public Yonetici(int id,string isim,string soyisim,int sorumlukisisayisi):base(id,isim,soyisim)
        {
            this.sorumlukisisayisi = sorumlukisisayisi;
        }

        public void zamyap(int zammiktari)
        { Console.WriteLine( getisim() + " " + zammiktari + " TL çalışanlara zam yapıyor..."); }

    }
}
