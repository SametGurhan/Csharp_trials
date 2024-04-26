using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Model
{
    public class Kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public DateTime olusturmaTarihi { get; set; }
        public string Kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public Kisi()
        {

        }
        public Kisi(int id, string isim, string soyisim, DateTime olusturmaTarihi, string Kullaniciadi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarihi = olusturmaTarihi;
            this.Kullaniciadi = Kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;


        }
        public void setId()
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getSoyisim()
        {
            return this.soyisim;
        }

        public void setOlusturmaTarihi(DateTime olusturmaTarihi)
        {
            this.olusturmaTarihi = olusturmaTarihi;
        }
        public DateTime getOlusturmaTarihi()
        {
            return this.olusturmaTarihi;
        }
        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.Kullaniciadi = kullaniciAdi;
        }
        public string getKullaniciAdi()
        {
            return this.Kullaniciadi;
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }

        public string getSifre()
        {
            return this.sifre;
        }

        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getYetki()
        {
            return this.yetki;
        }

        public override string ToString()
        {
            return "İsim-Soyisim:" + this.isim + " " + this.soyisim;
        }


    }
}
