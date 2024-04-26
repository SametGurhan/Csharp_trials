using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.yapici.metot
{
    public class kullanici
    {
        private int kullaniciID { get; set; }
        private int isim { get; set; }
        private int soyisim { get; set; }
        private static int maas { get; set; }

        static kullanici()
        {
            maas = 1500;
        }

        public kullanici(int kullaniciid,string isim,string soyisim)
        {
            kullaniciID = kullaniciid;
            isim = isim;
            soyisim = soyisim;
        }


        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanici bilgileri");
            Console.WriteLine("İd:"+kullaniciID);
            Console.WriteLine("İsim:"+isim);
            Console.WriteLine("Soyisim:"+soyisim);
            Console.WriteLine("Maas:"+maas);
        }
        
        public void zamyap(int zammiktsari)
        {
            Console.WriteLine("Kullaniciya zam yapiliyor...");
            Console.WriteLine("Şuanki maaşı:"+(maas+zammiktsari));

        }





    }
}
