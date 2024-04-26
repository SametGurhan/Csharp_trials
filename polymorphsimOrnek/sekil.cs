using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimOrnek
{
    public class sekil
    {   
        public string isim { get; set; }
        public sekil(string isim)
        {
            this.isim = isim;
        }
        public string getisim()
        {
            return this.isim; 
        }
        public virtual void sekilhesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor...");
        }

        public virtual void sekilbilgilerigoster()
        {
            Console.WriteLine(getisim() + "'nin bilgileri!"); 
        }

    }
}
