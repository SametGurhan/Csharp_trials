using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Calisan
    {
        private int id;
        private string isim;
        private string soyisim;
        public Calisan(int id, string isim, string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        { this.id = id; }

        public string getisim()
        {
            return this.isim;
        }
        public void setisim (string isim)
        { this.isim = isim; }

        public string getsoyisim()
        { return this.soyisim; }

        public void setsoyisim(string soyisim)
        { this.soyisim = soyisim; }

        public void bilgilerigöster()
        { 
            Console.WriteLine("İd:"+this.id);
            Console.WriteLine("İsim:"+this.isim);
            Console.WriteLine("Soyisim:"+this.soyisim);
        }

    }
}
