using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimGiris
{
    public class Hayvan
    {
        public string isim { get; set; }
        public Hayvan(string isim)
        {
            this.isim = isim;
        }
        public string getisim()
        {
            return this.isim;
        }
        public void setisim(string isim)
        {
            this.isim = isim;
        }
        public virtual void konus()
        { 
            Console.WriteLine("Hayvan konuşuyor."); 
        }

    }
}




