using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedKeyword
{
    public /*sealed*/ class Personel
    {
        public int personel_id { get; set; }
        public string personel_ismi { get; set; }
        public string personel_soyismi { get; set; }
        public int personel_maas { get; set; }
        public void PersonelBilgileri()
        {
            Console.WriteLine("personel id:"+personel_id);
            Console.WriteLine("Personel ismi:"+personel_ismi);
            Console.WriteLine("Personel soyisim:"+personel_soyismi);
            Console.WriteLine("personel maaş:"+personel_maas);

        }



    }
}
