using System;

namespace KutuphaneOtomasyon
{
    internal class Kisi
    {
        internal string getSifre;
        internal string getYetki;
        private int v1;
        private string v2;
        private string v3;
        private DateTime now;
        private string v4;
        private string v5;
        private string v6;

        public Kisi(int v1, string v2, string v3, DateTime now, string v4, string v5, string v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.now = now;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        internal string getKullaniciAdi()
        {
            throw new NotImplementedException();
        }
    }
}