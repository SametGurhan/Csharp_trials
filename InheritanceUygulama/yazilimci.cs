using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class yazilimci:Calisan
    {
        private string diller;
        public yazilimci(int id, string isim, string soyisim,string diller) : base(id, isim, soyisim)
        {
            this.diller = diller;
        }   
        public void formatat(string isletimsistemi)
        {
            Console.WriteLine(getisim()+" şuanda"+" "+isletimsistemi+" işletim sistemine format atıyor..."); 
        }


    }
}
