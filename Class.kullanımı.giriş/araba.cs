using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.kullanımı.giriş
{
    public class araba
    {/*public class araba
      {
        public int kapisayisi;
        public string arabamodel;
        public string arabarengi;
        
       public void motorcalistir()
        {  Console.WriteLine("motor çalışıyor..."); }

        public void kapilarikilitle()
        { Console.WriteLine("Kapilar kiltleniyor..."); }
      }
      
      
      
      */
        public int kapisayisi = 4;
        public string arabamodel;
        public string arabarengi;

        public araba(int kapisayisix, string arabamodelx, string arabarengix)//ctor tab +tab = yapıcı metot
        {
            kapisayisi = kapisayisix;
            arabamodel = arabamodelx;
            arabarengi = arabarengix;

        }

       

    }
}
