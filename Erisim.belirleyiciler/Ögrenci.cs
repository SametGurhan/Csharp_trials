using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim.belirleyiciler
{
    public class Ögrenci
    {
        private int id = 1;
        private string isim = "Samet";
        public string soyisim = "Gürhan";
        public string okul = " ÇOMÜ ";

     /*  public void setisim (string _isim)
        {
            _isim = isim;
        }
        public string getisim()
        {
            return isim ;
        }
     */
        private void adSoyadyazdir()//gizli kalıyor .açığa çıkarmak için geter seter kulllanıyoruzz ki klassta erişebilelim.
        {
            Console.WriteLine("Adı:" + isim + "Soyadı:" + soyisim);
        }
        public void okulYazdır()
        {
            Console.WriteLine("Okul ismi:"+okul);
        }

    }
}
